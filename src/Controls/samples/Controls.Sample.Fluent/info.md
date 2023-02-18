### Discussed in https://github.com/dotnet/maui/discussions/12273

I would like to have fluent API support in MAUI so first I created a library [https://github.com/idexus/Sharp.UI](https://github.com/idexus/Sharp.UI) then because some classes are sealed, I decided to create a fork [https://github.com/idexus/maui](https://github.com/idexus/maui) to fully support this feature in the MAUI project. Most code is generated using source generators.

I have two questions
- Is it possible to include fluent API support directly in the maui project?
- If there is no way to add such support to the maui project for now, is there a way to "unseal" the maui classes?

I think for many it would make it much easier to create an interface without the need for XAML, without disabling the possibility of using it.

My goal was:

```cs
new ScrollView
{
    new VerticalStackLayout
    {
        new Grid
        {
            new Label("Hello")
                .Column(0)
                .FontSize(28),
            
            new Label("World", out var label)
                .Column(1),

            new Button("Click me")
                .Row(1)
                .ColumnSpan(2)
                .OnClicked(button => {
                    label.Text = "you";
                });
        }
        .ColumnDefinitions(e => e.Star(2).Star(1))
        .RowDefinitions(e => e.Star().Absolute(100)),
            
        new Path
        {
            new GeometryGroup
            {
                new PathGeometry
                {
                    new PathFigure(15, 50)
                    {
                        new LineSegment(800,150),
                        new LineSegment(500,50)
                    }
                },

                new EllipseGeometry()
                    .Center(new Point(50,70))
                    .RadiusX(10)
                    .RadiusY(50),
            }
        }
        .Stroke(Colors.Yellow)
        .Fill(Colors.Red),
    }
}
```

Unfortunately some classes are sealed, e.g. 

`PathGeometry`, `PathFigure`, `TapGestureRecognizer`, `PinchGestureRecognizer`, `PointerGestureRecognizer`, `SwipeGestureRecognizer`, `Ellipse`, `Polyline`, `Line`, `Path`, `Polygon`, `Rectangle`, `RoundRectangle`, `TableSection`, `ColumnDefinition`, `RowDefinition` `Style`, `Trigger`,... etc.

If I wanted to create a library with these classes so that I could create the UI declaratively as I described, only in code using fluent interface, I can't do it without wrapping them.

# Detailed description

Below is a description of how each problem was solved.

## Properties

Fluent extension methods are generated for all properties and bindable properties (for all derived classes of `BindableObject`, and for `Style`, `VisualState`, `VisualStateGroup`, `VisualStateGroupList` classes)

Usage:
```cs
Label()
  .FontSize(28)
  .TextColor(Colors.White)
```
Generated methods for `FontSize` property:
```cs
public static T FontSize<T>(this T obj,
    double fontSize)
    where T : Microsoft.Maui.Controls.Label
{
    obj.FontSize = fontSize;
    return obj;
}

public static T FontSize<T>(this T obj,
    System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
    where T : Microsoft.Maui.Controls.Label
{
    var builder = buidValue(new ValueBuilder<double>());
    if (builder.ValueIsSet()) obj.FontSize = builder.GetValue();
    return obj;
}

public static T FontSize<T>(this T obj,
    System.Func<LazyValueBuilder<double>, LazyValueBuilder<double>> buidValue)
    where T : Microsoft.Maui.Controls.Label
{
    var builder = buidValue(new LazyValueBuilder<double>());
    if (builder.ValueIsSet()) obj.FontSize = builder.GetValue();
    return obj;
}

public static T FontSize<T>(this T obj,
    System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
    where T : Microsoft.Maui.Controls.Label
{
    var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Label.FontSizeProperty));
    builder.BindProperty();
    return obj;
}
```

## `EventHandler`

Fluent extension methods are generated for each `EventHandler` adding an `On` prefix

usage example:

```cs
new VerticalStackLayout
{
    new Label("Hello"),
    new Button("Click me")
        OnClicked(button => {

        });
}
```

generated methods for `Clicked` event handler:

```cs
public static T OnClicked<T>(this T obj, System.EventHandler handler)
    where T : Microsoft.Maui.Controls.Button
{
    obj.Clicked += handler;
    return obj;
}

public static T OnClicked<T>(this T obj, System.Action<T> action)
    where T : Microsoft.Maui.Controls.Button
{
    obj.Clicked += (o, arg) => action(obj);
    return obj;
}
```

## `ContentProperty` attributes

Implementation of `IList` (if not implemented yet) or `IEnumerable` interfaces to add `Add()` method support to class are generated for all classes with the `ContentProperty` attribute.

Example usage:

```cs
new Border
{
    new VerticalStackLayout
    {
        new Label("Hello").FontSize(28),
        new Grid
        {
            ...
        },
        new HorizontalStackLayout
        {
            new Label("foo"),
            new Button("OK").OnClicked(OnClickedButton)
        }

    }
}
```

Generated class implementation for single item containers:

```cs
public partial class Border : IEnumerable
{

    ...

    // ----- single item container -----

    public IEnumerator GetEnumerator() { yield return this.Content; }

    public void Add(Microsoft.Maui.Controls.View? content) => this.Content = content;

}
```

Generated class implementation for collection containers:

```cs
public partial class Shell : IList<Microsoft.Maui.Controls.ShellItem>
{

    ...

    // ----- collection container -----

    public int Count => this.Items.Count;
    public Microsoft.Maui.Controls.ShellItem this[int index] { get => this.Items[index]; set => this.Items[index] = value; }
    public bool IsReadOnly => false;
    public void Add(Microsoft.Maui.Controls.ShellItem item) => this.Items.Add(item);
    public void Clear() => this.Items.Clear();
    public bool Contains(Microsoft.Maui.Controls.ShellItem item) => this.Items.Contains(item);
    public void CopyTo(Microsoft.Maui.Controls.ShellItem[] array, int arrayIndex) => this.Items.CopyTo(array, arrayIndex);
    public IEnumerator<Microsoft.Maui.Controls.ShellItem> GetEnumerator() => this.Items.GetEnumerator();
    public int IndexOf(Microsoft.Maui.Controls.ShellItem item) => this.Items.IndexOf(item);
    public void Insert(int index, Microsoft.Maui.Controls.ShellItem item) => this.Items.Insert(index, item);
    public bool Remove(Microsoft.Maui.Controls.ShellItem item) => this.Items.Remove(item);
    public void RemoveAt(int index) => this.Items.RemoveAt(index);
    IEnumerator IEnumerable.GetEnumerator() => this.Items.GetEnumerator();

}
```

## Constructors

### Aditional constructors

Additional constructors have been added to simplify the interface creation process

example usage:

```cs
new VerticalStackLayout
{
    new Label("Hello"),
    new Button("Click me")
        OnClicked(button => {

        });
}
```

implementation

```cs
public partial class Label
{
    public Label(string text) : this()
    {
        this.Text = text;
    }
}
```

### Additional `out` parameter

Additional constructors with the `out` parameter are generated for all public constructors.

usage:

```cs
new VerticalStackLayout
{
    new Label("Hello", out var label)
    new Button("Click me")
        OnClicked(button => {
            label.Text = "Clicked";
        });
}
```
genetated constructor:

```cs
public partial class Label : IEnumerable
{

    // ----- constructors -----

    public Label(out Label label) : this()
    {
        label = this;
    }

    public Label(string text, out Label label) : this(text)
    {
        label = this;
    }

    ...
}
```

## In-line value builders

### `BindingBuilder`

For in-line creation of bindings

usage:

```cs
new VerticalStackLayout
{
    new Slider(1, 100, 1, out var slider),
    new Label()
        .Text(e => e.Path("Value").Source(slider).StringFormat("Value {0:F1}"))
}
```

### `ValueBuilder`

To set values depending on the app theme, platform or device idiom

```cs
new Label("Hello")
    .TextColor(e => e.OnDark(Colors.White).OnLight(Colors.Black))
    .FontSize(e => e.Default(28).OnPhone(18).OnTV(40))
```

### `LazyValueBuilder`

To lazily set values depending on the app theme, platform or device idiom

```cs
new Label()
    .Text(e => e
        .Default(() => DefaultName())
        .OnAndroid(() => AndroidName())
    )
```

### `ColumnDefinitionBuilder` and `RowDefinitionBuilder`

To define the number and sizes of rows and columns.

example:

```cs
new Grid
{
    ...
}
.RowDefinitions(e => e.Star(2).Star().Star(3))
.ColumnDefinitions(e => e.Absolute(100).Star());
``` 

In this example you define
- 3 rows - `Star(2)`, `Star()`, `Star(3)`
- 2 columns - `Absolute(100)`, `Star()`

## Style

### `BindableProperty` => `Setter`

```cs
Button.BackgroundColorProperty.Set(Colors.White),

Button.TextColorProperty.Set().OnLight(Colors.White).OnDark(AppColors.Primary),
```

implementation

```cs
public static class BindablePropertyExtension
{
    public static Setter Set(this BindableProperty property, object value) => new Setter { Property = property, Value = value };
    public static Setter Set(this BindableProperty property) => new Setter { Property = property };		
}

public static class SetterExtension
{
    public static Setter OnLight(this Setter setter, object value) { if (Application.Current?.RequestedTheme == AppTheme.Light) setter.Value = value; return setter; }
    public static Setter OnDark(this Setter setter, object value) { if (Application.Current?.RequestedTheme == AppTheme.Dark) setter.Value = value; return setter; }
    ...
}
```

### `IList` Add methods

Additional `Add()` methods for the `IList` interface

```cs
public partial class Style
{
    public void Add(Setter setter) {...}
    public void Add(Trigger trigger) {...}
    public void Add(DataTrigger trigger) {...}
    public void Add(VisualStateGroupList groupList) {...}
    public void Add(VisualStateGroup group) {...}
    public void Add(VisualState visualState) {...}
}
```

Usage example
```cs
new Style(typeof(Button))
{
    Button.TextColorProperty.Set().OnLight(Colors.White).OnDark(AppColors.Primary),
    Button.BackgroundColorProperty.Set().OnLight(AppColors.Primary).OnDark(Colors.White),
    Button.FontSizeProperty.Set(14).OnDesktop(20),
    Button.CornerRadiusProperty.Set(8).OniOS(15),
    new VisualState(VisualState.VisualElement.Normal)
    {
        Button.TextColorProperty.Set().OnLight(Colors.White).OnDark(AppColors.Primary),
        Button.BackgroundColorProperty.Set().OnLight(AppColors.Primary).OnDark(Colors.White),
    },
    new VisualState(VisualState.VisualElement.Disabled)
    {
        Button.TextColorProperty.Set().OnLight(AppColors.Gray950).OnDark(AppColors.Gray200),
        Button.BackgroundColorProperty.Set().OnLight(AppColors.Gray200).OnDark(AppColors.Gray600),
    },
},
```


## User defined classes

### `[FluentInterface]` attribute

Fluent methods will be generated for user definied classes with the `[FluentInterface]` attribute

### `[BindableProperties]` attribute

Bindable properties and fluent methods will be generated for user definied classes with interfaces with the `[BindableProperties]` attribute

##### Additional atributes:

- `[DefaultValue]` to define default values
- `[PropertyCallbacks(propertyChanged, propertyChanging,validateValue, coerceValue, defaultValueCreator]` to define callback names

##### Example

```cs
[BindableProperties]
public interface IAngleViewModelProperties
{
    [PropertyCallbacks(propertyChanged: "OnAngleChanged")]
    public double RawAngle { get; set; }

    [PropertyCallbacks(coerceValue: "CoerceAngle")]
    public double Angle { get; set; }

    [DefaultValue(360.0)]
    public double MaximumAngle { get; set; }
}


[FluentInterface]
public partial class AngleViewModel : BindableObject, IAngleViewModelProperties
{
    static void OnAngleChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var viewModel = bindable as AngleViewModel;
        viewModel.Angle = (double)newValue;
    }

    static object CoerceAngle(BindableObject bindable, object value)
    {
        var viewModel = bindable as AngleViewModel;
        double input = (double)value;

        if (input > viewModel.MaximumAngle)
            input = viewModel.MaximumAngle;

        return input;
    }
}
```

## Custom user view example

```cs
[BindableProperties]
public interface ICardViewProperties
{
    string CardTitle { get; set; }
    string CardDescription { get; set; }
    Color CardColor { get; set; }
    Color BorderColor { get; set; }
    Style DescriptionStyle { get; set; }
    View ContentView { get; set; }
    string ButtonTitle { get; set; }
}

[FluentInterface]
[ContentProperty(nameof(ContentView))]
public partial class CardView : ContentView, ICardViewProperties
{
    public event EventHandler Clicked;

    public CardView()
    {
        this.BindingContext = this;
        Content = new Border
        {
            new Grid
            {
                new VerticalStackLayout
                {
                    new Label(out var label1)
                        .Text(e => e.Path(nameof(CardTitle)))
                        .FontSize(29)
                        .TextColor(Colors.White),

                    new Label()
                        .Text(e => e.Path(nameof(CardDescription)))
                        .Style(e => e.Path(nameof(DescriptionStyle))),
                },

                new ContentView()
                    .Row(1)
                    .Content(e => e.Path(nameof(ContentView)))
                    .HorizontalOptions(LayoutOptions.Center)
                    .VerticalOptions(LayoutOptions.Center)
                    .SizeRequest(120,120),

                new Button()
                    .Row(2)
                    .Text(e => e.Path(nameof(ButtonTitle)))
                    .BackgroundColor(Colors.LightGray)
                    .TextColor(Colors.Black)
                    .OnClicked((sender, e) => Clicked(sender,e))
            }
            .RowDefinitions(e => e.Star(1.0).Star(2.0).Star(0.7))
            .RowSpacing(10)
        }
        .StrokeShape(new RoundRectangle().CornerRadius(10))
        .Stroke(e => e.Path(nameof(BorderColor)))
        .BackgroundColor(e => e.Path(nameof(CardColor)))
        .SizeRequest(200, 300)
        .Margin(50)
        .Padding(20);
    }
}

public partial class CardViewPage : ContentPage
{
    public CardViewPage()
    {
        this.Content = new VerticalStackLayout
        {
            new Slider(1, 100, 1, out var slider),

            new HorizontalStackLayout
            {
                new CardView(out var cardNo1)
                {
                    new Image("dotnet_bot.png").Aspect(Aspect.AspectFit)
                }
                .CardTitle(e => e.Path("Value").Source(slider).StringFormat("Value {0:F1}"))
                .ButtonTitle("Play")
                .CardDescription("Do you like it")
                .CardColor(Colors.DarkSlateGrey)
                .BorderColor(Colors.DarkGrey)
                .OnClicked(e =>
                {
                    cardNo1.CardDescription = "Let's play :)";
                }),

                new CardView(out var cardView)
                {
                    new VerticalStackLayout
                    {
                        new Label("This is a simple card view example"),
                        new Label("Second label")
                            .TextColor(Colors.Red)
                            .FontSize(18)
                    }					
                }
                .CardTitle("Title 2")
                .ButtonTitle("Stop")
                .CardColor(Colors.DarkSlateGrey)
                .BorderColor(Colors.DarkGrey)
                .DescriptionStyle(new Style(typeof(Label))
                {
                    Label.TextColorProperty.Set(Colors.Blue),
                    Label.FontSizeProperty.Set(20)
                })
            }
            .HorizontalOptions(LayoutOptions.Center)
        }
        .VerticalOptions(LayoutOptions.Center)
        .Padding(100);
    }
}
```
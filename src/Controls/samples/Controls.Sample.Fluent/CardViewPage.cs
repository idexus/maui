using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Fluent;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;

namespace Maui.Controls.Sample.Fluent;

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

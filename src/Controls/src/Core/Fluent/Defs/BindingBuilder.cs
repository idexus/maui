using System;
using System.Globalization;

namespace Microsoft.Maui.Controls.Fluent
{
	public class BindingBuilder<T>
	{
		public class ValueConverter : IValueConverter
		{
			internal System.Func<object, object> FuncConvert = null;
			internal System.Func<object, object> FuncConvertBack = null;

			public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
			{
				if (value != null && FuncConvert != null)
					return FuncConvert(value);
				return null;
			}

			public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
			{
				if (value != null && FuncConvertBack != null)
					return FuncConvertBack(value);
				return null;
			}
		}

		//--- bindable ---

		public BindingBuilder<T> Path(string path) { this.path = path; return this; }
		public BindingBuilder<T> StringFormat(string stringFormat) { this.stringFormat = stringFormat; return this; }
		public BindingBuilder<T> BindingMode(BindingMode bindingMode) { this.bindingMode = bindingMode; return this; }
		public BindingBuilder<T> Converter(IValueConverter converter) { this.converter = converter; return this; }
		public BindingBuilder<T> Parameter(string converterParameter) { this.converterParameter = converterParameter; return this; }
		public BindingBuilder<T> Source(object source) { this.source = source; return this; }

		public BindingBuilder<T> Convert<Q>(Func<Q, T> convert)
		{
			if (valueConverter == null)
				valueConverter = new ValueConverter();
			valueConverter.FuncConvert = e => convert((Q)e);
			this.converter = valueConverter;
			return this;
		}

		public BindingBuilder<T> ConvertBack<Q>(Func<T, Q> convert)
		{
			if (valueConverter == null)
				valueConverter = new ValueConverter();
			valueConverter.FuncConvertBack = e => convert((T)e);
			this.converter = valueConverter;
			return this;
		}

		string path = null;
		BindingMode bindingMode = Microsoft.Maui.Controls.BindingMode.Default;
		IValueConverter converter = null;
		ValueConverter valueConverter = null;
		string converterParameter = null;
		string stringFormat = null;
		object source = null;

		private BindableObject obj;
		private BindableProperty property;

		public BindingBuilder(BindableObject obj, BindableProperty property)
		{
			this.obj = obj;
			this.property = property;
		}

		public void BindProperty()
		{
			if (path != null)
			{
				obj.SetBinding(
					targetProperty: property,
					binding: new Microsoft.Maui.Controls.Binding(
						path: path,
						mode: bindingMode,
						converter: converter,
						converterParameter: converterParameter,
						stringFormat: stringFormat,
						source: source));
			}
		}
	}
}


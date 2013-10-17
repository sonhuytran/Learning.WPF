using System.Windows.Controls;
using System.Windows;
using System;

namespace Recipe_01_03
{
    /// <summary>
    /// Interaction logic for MyControl.xaml
    /// </summary>
    public partial class MyControl : UserControl
    {
        public MyControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        #region TextFontWeight Dependency Property

        public static readonly DependencyProperty TextFontWeightProperty =
            DependencyProperty.Register(
                "TextFontWeight", typeof(FontWeight), typeof(MyControl),
                new FrameworkPropertyMetadata(FontWeights.Normal,
                    FrameworkPropertyMetadataOptions.AffectsArrange
                    & FrameworkPropertyMetadataOptions.AffectsMeasure
                    & FrameworkPropertyMetadataOptions.AffectsRender,
                    MyControl.TextFontWeight_PropertyChanged,
                    MyControl.TextFontWeight_CoerceValue));

        public FontWeight TextFontWeight
        {
            get
            {
                return (FontWeight)this.GetValue(TextFontWeightProperty);
            }

            set
            {
                this.SetValue(TextFontWeightProperty, value);
            }
        }

        public static object TextFontWeight_CoerceValue(DependencyObject d, object value)
        {
            FontWeight fontWeight = (FontWeight)value;

            if (FontWeights.Bold.Equals(fontWeight)
                || FontWeights.Normal.Equals(fontWeight))
            {
                return fontWeight;
            }

            return FontWeights.Normal;
        }

        public static void TextFontWeight_PropertyChanged(DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            MyControl myControl = d as MyControl;

            if (null != myControl)
            {
                FontWeight fontWeight = (FontWeight)e.NewValue;
                string fontWeightName;

                if (FontWeights.Bold.Equals(fontWeight))
                {
                    fontWeightName = "Bold";
                }
                else
                {
                    fontWeightName = "Normal";
                }

                myControl.txblFontWeight.Text = string.Format("Font weight set to: {0}.",
                    fontWeightName);
            }
        }

        #endregion TextFontWeight Dependency Property

        #region TextContent Dependency Property

        public static readonly DependencyProperty TextContentProperty =
            DependencyProperty.Register(
                "TextContentProperty", typeof(string), typeof(MyControl),
                new FrameworkPropertyMetadata(
                    "Default Value",
                    FrameworkPropertyMetadataOptions.AffectsArrange
                    & FrameworkPropertyMetadataOptions.AffectsMeasure
                    & FrameworkPropertyMetadataOptions.AffectsRender));

        public string TextContent
        {
            get
            {
                return (string)this.GetValue(TextContentProperty);
            }

            set
            {
                this.SetValue(TextContentProperty, value);
            }
        }

        #endregion TextContent Dependency Property
    }
}

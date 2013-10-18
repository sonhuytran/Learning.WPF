using System.Windows;
using System.Windows.Controls;

namespace Recipe_01_09
{
    class Parent : StackPanel
    {
        #region PropertyThatInherits Dependency Property

        public static readonly DependencyProperty PropertyThatInheritsProperty =
            DependencyProperty.RegisterAttached("PropertyThatInherits",
                typeof(string),
                typeof(UIElement),
                new FrameworkPropertyMetadata("Inherits.",
                    FrameworkPropertyMetadataOptions.Inherits));

        public string PropertyThatInherits
        {
            get
            {
                return this.GetValue(PropertyThatInheritsProperty) as string;
            }

            set
            {
                this.SetValue(PropertyThatInheritsProperty, value);
            }
        }

        #endregion PropertyThatInherits Dependency Property

        #region PropertyThatDoesNotInherits Dependency Property

        public static readonly DependencyProperty PropertyThatDoesNotInheritsProperty =
            DependencyProperty.RegisterAttached("PropertyThatDoesNotInherits",
                typeof(string), typeof(UIElement),
                new FrameworkPropertyMetadata("Does not inherit."));

        public string PropertyThatDoesNotInherits
        {
            get
            {
                return this.GetValue(PropertyThatDoesNotInheritsProperty) as string;
            }

            set
            {
                this.SetValue(PropertyThatDoesNotInheritsProperty, value);
            }
        }

        #endregion PropertyThatDoesNotInherits Dependency Property
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Globals.MyControlsSchemas.Controls.MyButton
{
    public class ButtonBasic : ISetControl
    {
        public Style SetControlProperties(double fontSize)
        {
            double actualFontsize = fontSize;

            Style buttonStyle = new Style(typeof(System.Windows.Controls.Button));
            buttonStyle.Setters.Add(new Setter(Control.FontSizeProperty, fontSize));


            buttonStyle.Setters.Add(new EventSetter(UIElement.MouseEnterEvent, new MouseEventHandler(Button_MouseEnter)));
            buttonStyle.Setters.Add(new EventSetter(UIElement.MouseLeaveEvent, new MouseEventHandler(Button_MouseLeave)));

            void Button_MouseEnter(object sender, MouseEventArgs e)
            {
                System.Windows.Controls.Button button = sender as System.Windows.Controls.Button;
                if (button != null)
                {
                    if (button.Content is string)
                    {
                        button.FontSize = actualFontsize + 1;
                    }
                    else if (button.Content is Image image)
                    {
                        ScaleTransform scaleTransform = new ScaleTransform(1.1, 1.1); //  20% zoom
                        image.RenderTransform = scaleTransform;
                        image.RenderTransformOrigin = new Point(0.5, 0.5); // Setting the scaling center to the middle of the image.
                    }
                    else if (button.Content is TimeSpan)
                    {
                        button.FontSize = actualFontsize + 0.5;
                    }
                }
            }

            void Button_MouseLeave(object sender, MouseEventArgs e)
            {
                System.Windows.Controls.Button button = sender as System.Windows.Controls.Button;
                if (button != null)
                {
                    if (button.Content is string)
                    {
                        button.FontSize = actualFontsize - 1;
                    }
                    else if (button.Content is Image image)
                    {
                        // Return to original scale.
                        ScaleTransform scaleTransform = new ScaleTransform(1.0, 1.0); // Powrót do oryginalnej skali
                        image.RenderTransform = scaleTransform;
                        image.RenderTransformOrigin = new Point(0.5, 0.5); // Setting the scaling center to the middle of the image.
                    }
                    else if (button.Content is TimeSpan)
                    {
                        button.FontSize = actualFontsize - 0.5;
                    }
                }
            }

            ControlTemplate buttonTemplate = new ControlTemplate(typeof(System.Windows.Controls.Button));

            // Creating factory for Border
            var border = new FrameworkElementFactory(typeof(Border));
            border.SetBinding(Border.BackgroundProperty, new Binding("Background") { RelativeSource = new RelativeSource(RelativeSourceMode.TemplatedParent) });
            border.SetValue(Border.BorderBrushProperty, Brushes.Transparent);
            border.SetValue(Border.BorderThicknessProperty, new Thickness(1));

            // Creating factory for ContentPresenter, which will display the content of the button.
            var contentPresenter = new FrameworkElementFactory(typeof(ContentPresenter));
            contentPresenter.SetValue(ContentPresenter.ContentProperty, new TemplateBindingExtension(ContentControl.ContentProperty));
            //contentPresenter.SetValue(TextElement.FontSizeProperty, new TemplateBindingExtension(Control.FontSizeProperty));
            contentPresenter.SetValue(FrameworkElement.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            contentPresenter.SetValue(FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Center);

            // Add ContentPresenter to Border
            border.AppendChild(contentPresenter);

            // Set VisualTree schema
            buttonTemplate.VisualTree = border;

            // Add schema to the style
            buttonStyle.Setters.Add(new Setter(Control.TemplateProperty, buttonTemplate));

            return buttonStyle;
        }
    }
}

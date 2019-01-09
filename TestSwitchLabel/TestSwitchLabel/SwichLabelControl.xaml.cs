// ----- Visual Studio Magazine
//       Sample code for SwitchLabelControl project
//       by Tim Patrick

using System;
using Xamarin.Forms;

namespace TestSwitchLabel
{
    public partial class SwichLabelControl : ContentView
    {
        public SwichLabelControl()
        {
            InitializeComponent();
        }

        public void AddElement()
        {
            Grid.Children.Add(new Label { Text = "Hola" }, 0, 3);
        }

        public static BindableProperty TextProperty = BindableProperty.Create(
            propertyName: "Text",
            returnType: typeof(string),
            declaringType: typeof(ContentView),
            defaultValue: string.Empty,
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: HandleTextPropertyChanged);

        public string Text
        {
            // ----- The display text for the composite control.
            get { return (string)base.GetValue(TextProperty); }
            set
            {
                if (value != this.Text)
                    base.SetValue(TextProperty, value);
            }
        }

        private static void HandleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // ----- Someone changed the full control's Text property.
            //       Store that new value in the internal Label’s Text property.
            SwichLabelControl targetView;

            targetView = (SwichLabelControl)bindable;
            if (targetView != null)
                targetView.SwitchText.Text = (string)newValue;
        }

        public static BindableProperty ValueProperty = BindableProperty.Create(
            propertyName: "Value",
            returnType: typeof(bool),
            declaringType: typeof(ContentView),
            defaultValue: false,
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: HandleValuePropertyChanged);

        public bool Value
        {
            // ----- The toggle value of the internal Switch control.
            get { return (bool)base.GetValue(ValueProperty); }
            set
            {
                if (this.Value != value)
                {
                    base.SetValue(ValueProperty, value);

                    // ----- Also notify by standard event handler.
                    this.OnValueToggled(new ToggledEventArgs(value));
                }
            }
        }

        private static void HandleValuePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // ----- Someone changed the full control's Value property. Store
            //       that new value in the internal Switch’s IsToggled property.
            SwichLabelControl targetView;

            targetView = (SwichLabelControl)bindable;
            if (targetView != null)
                targetView.SwitchValue.IsToggled = (bool)newValue;
        }

        public event EventHandler<ToggledEventArgs> ValueToggled;
        protected virtual void OnValueToggled(ToggledEventArgs e)
        {
            // ----- Event handler for value changes.
            ValueToggled?.Invoke(this, e);
        }

        private void SwitchValue_Toggled(object sender, ToggledEventArgs e)
        {
            // ----- Communicate the new value back to the property.
            this.Value = e.Value;
        }
    }
}

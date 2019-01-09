using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestSwitchLabel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MedusaButtonGroup : ContentView
    {
        public MedusaButtonGroup()
        {
            InitializeComponent();
            _buttonColor = buttonA.BackgroundColor;
        }

        //Tristate Behaviour ===================
        public static BindableProperty TriStateProperty = BindableProperty.Create(
            propertyName: "TriState",
            returnType: typeof(bool),
            declaringType: typeof(ContentView),
            defaultValue: false,
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: HandleTriStatePropertyChanged);

        public bool TriState
        {
            // ----- The button behavior
            get { return (bool)base.GetValue(TriStateProperty); }
            set
            {
                if (value != this.TriState)
                    base.SetValue(TriStateProperty, value);
            }
        }


        private static void HandleTriStatePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // ----- Someone changed control's behavior.
            //       Store that new value in the internal property.
            MedusaButtonGroup targetView;

            targetView = (MedusaButtonGroup)bindable;
            if (targetView != null)
            {
            }
        }

        //Button Behaviour ===================
        public static BindableProperty RadioBehaviorProperty = BindableProperty.Create(
            propertyName: "RadioBehavior",
            returnType: typeof(bool),
            declaringType: typeof(ContentView),
            defaultValue: false,
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: HandleRadioBehaviorPropertyChanged);

        public bool RadioBehavior
        {
            // ----- The button behavior
            get { return (bool)base.GetValue(RadioBehaviorProperty); }
            set
            {
                if (value != this.RadioBehavior)
                    base.SetValue(RadioBehaviorProperty, value);
            }
        }


        private static void HandleRadioBehaviorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // ----- Someone changed control's behavior.
            //       Store that new value in the internal property.
            MedusaButtonGroup targetView;

            targetView = (MedusaButtonGroup)bindable;
            if (targetView != null)
            {
            }
        }

        private Color _buttonColor;
        private Color _toggledOnColor = Color.LightGreen;
        private Color _toggledTriColor = Color.Orange;

        public void ClearButtons()
        {
            buttonA.BackgroundColor = _buttonColor;
            buttonB.BackgroundColor = _buttonColor;
            buttonC.BackgroundColor = _buttonColor;
            buttonD.BackgroundColor = _buttonColor;
        }

        public void SetButtons(string[] captions, bool triState, bool radio)
        {
            TriState = triState;
            RadioBehavior = radio;
            for (int i = 0; i < captions.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        buttonA.Text = captions[i];
                        buttonA.IsEnabled = true;
                        buttonA.IsVisible = true;
                        break;
                    case 1:
                        buttonB.Text = captions[i];
                        buttonB.IsEnabled = true;
                        buttonB.IsVisible = true;
                        break;
                    case 2:
                        buttonC.Text = captions[i];
                        buttonC.IsEnabled = true;
                        buttonC.IsVisible = true;
                        break;
                    case 3:
                        buttonD.Text = captions[i];
                        buttonD.IsEnabled = true;
                        buttonD.IsVisible = true;
                        break;
                    default:
                        break;
                }
            }

        }

        public void ToggleButton(int index)
        {
            if (TriState)
            {
                switch (index)
                {
                    case 0:
                        if (buttonA.BackgroundColor == _buttonColor)
                        {
                            buttonA.BackgroundColor = _toggledOnColor;
                        }
                        else
                        {
                            if (buttonA.BackgroundColor == _toggledOnColor)
                            {
                                buttonA.BackgroundColor = _toggledTriColor;
                            }
                            else
                            {
                                buttonA.BackgroundColor = _buttonColor;
                            }
                        }
                        break;
                    case 1:
                        if (buttonB.BackgroundColor == _buttonColor)
                        {
                            buttonB.BackgroundColor = _toggledOnColor;
                        }
                        else
                        {
                            if (buttonB.BackgroundColor == _toggledOnColor)
                            {
                                buttonB.BackgroundColor = _toggledTriColor;
                            }
                            else
                            {
                                buttonB.BackgroundColor = _buttonColor;
                            }
                        }
                        break;
                    case 2:
                        if (buttonC.BackgroundColor == _buttonColor)
                        {
                            buttonC.BackgroundColor = _toggledOnColor;
                        }
                        else
                        {
                            if (buttonC.BackgroundColor == _toggledOnColor)
                            {
                                buttonC.BackgroundColor = _toggledTriColor;
                            }
                            else
                            {
                                buttonC.BackgroundColor = _buttonColor;
                            }
                        }
                        break;
                    case 3:
                        if (buttonD.BackgroundColor == _buttonColor)
                        {
                            buttonD.BackgroundColor = _toggledOnColor;
                        }
                        else
                        {
                            if (buttonD.BackgroundColor == _toggledOnColor)
                            {
                                buttonD.BackgroundColor = _toggledTriColor;
                            }
                            else
                            {
                                buttonD.BackgroundColor = _buttonColor;
                            }
                        }
                        break;
                }

            }
            else
            {
                switch (index)
                {
                    case 0:
                        buttonA.BackgroundColor = buttonA.BackgroundColor == _buttonColor ? _toggledOnColor : _buttonColor;
                        break;
                    case 1:
                        buttonB.BackgroundColor = buttonB.BackgroundColor == _buttonColor ? _toggledOnColor : _buttonColor;
                        break;
                    case 2:
                        buttonC.BackgroundColor = buttonC.BackgroundColor == _buttonColor ? _toggledOnColor : _buttonColor;
                        break;
                    case 3:
                        buttonD.BackgroundColor = buttonD.BackgroundColor == _buttonColor ? _toggledOnColor : _buttonColor;
                        break;
                }
            }
        }
        //Oritentation =================


        //public static BindableProperty OrientationProperty = BindableProperty.Create(
        //    propertyName: "Orientation",
        //    returnType: typeof(StackOrientation),
        //    declaringType: typeof(ContentView),
        //    defaultValue: StackOrientation.Horizontal,
        //    defaultBindingMode: BindingMode.OneWay,
        //    propertyChanged: HandleOrientationPropertyChanged);

        //public StackOrientation Orientation
        //{
        //    // ----- The button layout Orientation
        //    get { return (StackOrientation)base.GetValue(OrientationProperty); }
        //    set
        //    {
        //        if (value != this.Orientation)
        //            base.SetValue(OrientationProperty, value);
        //    }
        //}


        //private static void HandleOrientationPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    // ----- Someone changed the full control's Orientation property.
        //    //       Store that new value in the internal property.
        //    MedusaButtonGroup targetView;

        //    targetView = (MedusaButtonGroup)bindable;
        //    if (targetView != null)
        //        targetView.buttonLayout.Orientation = (StackOrientation)newValue;
        //}

        private void ButtonInstanceA_Clicked(object sender, EventArgs e)
        {
            if (RadioBehavior)
            {
                ClearButtons();
            }
            ToggleButton(0);
        }
        private void ButtonInstanceB_Clicked(object sender, EventArgs e)
        {
            if (RadioBehavior)
            {
                ClearButtons();
            }
            ToggleButton(1);
        }
        private void ButtonInstanceC_Clicked(object sender, EventArgs e)
        {
            if (RadioBehavior)
            {
                ClearButtons();
            }
            ToggleButton(2);
        }
        private void ButtonInstanceD_Clicked(object sender, EventArgs e)
        {
            if (RadioBehavior)
            {
                ClearButtons();
            }
            ToggleButton(3);
        }
    }
}
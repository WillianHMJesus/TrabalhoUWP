﻿#pragma checksum "D:\Willian Hilton\Fiap\UWP\TrabalhoUWP\TrabalhoUWP\View\AppSettingPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5A4CF28F4D4C7594062E9D234B279A69"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrabalhoUWP.View
{
    partial class AppSettingPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_SplitView_IsPaneOpen(global::Windows.UI.Xaml.Controls.SplitView obj, global::System.Boolean value)
            {
                obj.IsPaneOpen = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton obj, global::System.Nullable<global::System.Boolean> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Nullable<global::System.Boolean>) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Nullable<global::System.Boolean>), targetNullValue);
                }
                obj.IsChecked = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class AppSettingPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAppSettingPage_Bindings
        {
            private global::TrabalhoUWP.View.AppSettingPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.SplitView obj2;
            private global::Windows.UI.Xaml.Controls.Button obj6;
            private global::Windows.UI.Xaml.Controls.Button obj7;
            private global::Windows.UI.Xaml.Controls.Button obj8;
            private global::Windows.UI.Xaml.Controls.Button obj9;
            private global::Windows.UI.Xaml.Controls.Button obj10;
            private global::Windows.UI.Xaml.Controls.RadioButton obj11;
            private global::Windows.UI.Xaml.Controls.RadioButton obj12;
            private global::Windows.UI.Xaml.Controls.RadioButton obj13;

            private AppSettingPage_obj1_BindingsTracking bindingsTracking;

            public AppSettingPage_obj1_Bindings()
            {
                this.bindingsTracking = new AppSettingPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // View\AppSettingPage.xaml line 15
                        this.obj2 = (global::Windows.UI.Xaml.Controls.SplitView)target;
                        (this.obj2).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.SplitView.IsPaneOpenProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.ViewModelContato.IsSplitViewOpen = this.obj2.IsPaneOpen;
                            }
                        });
                        break;
                    case 6: // View\AppSettingPage.xaml line 52
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.ViewModelContato.HamburguerButton_Click();
                        };
                        break;
                    case 7: // View\AppSettingPage.xaml line 96
                        this.obj7 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.ViewModelContato.AppSettingsButton_Click();
                        };
                        break;
                    case 8: // View\AppSettingPage.xaml line 83
                        this.obj8 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.ViewModelContato.NovoContatoButton_Click();
                        };
                        break;
                    case 9: // View\AppSettingPage.xaml line 73
                        this.obj9 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.ViewModelContato.ListaContatoFavorito_Click();
                        };
                        break;
                    case 10: // View\AppSettingPage.xaml line 63
                        this.obj10 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.ViewModelContato.ListaContatoButton_Click();
                        };
                        break;
                    case 11: // View\AppSettingPage.xaml line 112
                        this.obj11 = (global::Windows.UI.Xaml.Controls.RadioButton)target;
                        (this.obj11).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.ViewModel.AppThemeSetting = (global::System.Nullable<global::System.Int32>)this.LookupConverter("RadioButtonToNullableInt").ConvertBack(this.obj11.IsChecked, typeof(global::System.Nullable<global::System.Int32>), "0", null);
                            }
                        });
                        break;
                    case 12: // View\AppSettingPage.xaml line 114
                        this.obj12 = (global::Windows.UI.Xaml.Controls.RadioButton)target;
                        (this.obj12).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.ViewModel.AppThemeSetting = (global::System.Nullable<global::System.Int32>)this.LookupConverter("RadioButtonToNullableInt").ConvertBack(this.obj12.IsChecked, typeof(global::System.Nullable<global::System.Int32>), "1", null);
                            }
                        });
                        break;
                    case 13: // View\AppSettingPage.xaml line 116
                        this.obj13 = (global::Windows.UI.Xaml.Controls.RadioButton)target;
                        (this.obj13).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.ViewModel.AppThemeSetting = (global::System.Nullable<global::System.Int32>)this.LookupConverter("RadioButtonToNullableInt").ConvertBack(this.obj13.IsChecked, typeof(global::System.Nullable<global::System.Int32>), null, null);
                            }
                        });
                        break;
                    default:
                        break;
                }
            }

            // IAppSettingPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::TrabalhoUWP.View.AppSettingPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::TrabalhoUWP.View.AppSettingPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModelContato(obj.ViewModelContato, phase);
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModelContato(global::TrabalhoUWP.ViewModel.ContatoViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModelContato(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModelContato_IsSplitViewOpen(obj.IsSplitViewOpen, phase);
                    }
                }
            }
            private void Update_ViewModelContato_IsSplitViewOpen(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\AppSettingPage.xaml line 15
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_SplitView_IsPaneOpen(this.obj2, obj);
                }
            }
            private void Update_ViewModel(global::TrabalhoUWP.ViewModel.AppSettingViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_AppThemeSetting(obj.AppThemeSetting, phase);
                    }
                }
            }
            private void Update_ViewModel_AppThemeSetting(global::System.Nullable<global::System.Int32> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\AppSettingPage.xaml line 112
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj11, (global::System.Nullable<global::System.Boolean>)this.LookupConverter("RadioButtonToNullableInt").Convert(obj, typeof(global::System.Nullable<global::System.Boolean>), "0", null), null);
                    // View\AppSettingPage.xaml line 114
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj12, (global::System.Nullable<global::System.Boolean>)this.LookupConverter("RadioButtonToNullableInt").Convert(obj, typeof(global::System.Nullable<global::System.Boolean>), "1", null), null);
                    // View\AppSettingPage.xaml line 116
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj13, (global::System.Nullable<global::System.Boolean>)this.LookupConverter("RadioButtonToNullableInt").Convert(obj, typeof(global::System.Nullable<global::System.Boolean>), null, null), null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
            private class AppSettingPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<AppSettingPage_obj1_Bindings> weakRefToBindingObj; 

                public AppSettingPage_obj1_BindingsTracking(AppSettingPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<AppSettingPage_obj1_Bindings>(obj);
                }

                public AppSettingPage_obj1_Bindings TryGetBindingObject()
                {
                    AppSettingPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModelContato(null);
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModelContato(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AppSettingPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::TrabalhoUWP.ViewModel.ContatoViewModel obj = sender as global::TrabalhoUWP.ViewModel.ContatoViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModelContato_IsSplitViewOpen(obj.IsSplitViewOpen, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "IsSplitViewOpen":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModelContato_IsSplitViewOpen(obj.IsSplitViewOpen, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::TrabalhoUWP.ViewModel.ContatoViewModel cache_ViewModelContato = null;
                public void UpdateChildListeners_ViewModelContato(global::TrabalhoUWP.ViewModel.ContatoViewModel obj)
                {
                    if (obj != cache_ViewModelContato)
                    {
                        if (cache_ViewModelContato != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModelContato).PropertyChanged -= PropertyChanged_ViewModelContato;
                            cache_ViewModelContato = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModelContato = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModelContato;
                        }
                    }
                }
                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AppSettingPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::TrabalhoUWP.ViewModel.AppSettingViewModel obj = sender as global::TrabalhoUWP.ViewModel.AppSettingViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_AppThemeSetting(obj.AppThemeSetting, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "AppThemeSetting":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_AppThemeSetting(obj.AppThemeSetting, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::TrabalhoUWP.ViewModel.AppSettingViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::TrabalhoUWP.ViewModel.AppSettingViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // View\AppSettingPage.xaml line 15
                {
                    this.splitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // View\AppSettingPage.xaml line 19
                {
                    this.VisualStateGroupScreenWidth = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 4: // View\AppSettingPage.xaml line 20
                {
                    this.VisualStateMinWidth700 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5: // View\AppSettingPage.xaml line 31
                {
                    this.VisualStateMinWidth1 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // View\AppSettingPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    AppSettingPage_obj1_Bindings bindings = new AppSettingPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}


﻿#pragma checksum "D:\Willian Hilton\Fiap\UWP\TrabalhoUWP\TrabalhoUWP\View\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A51490DE485D3B9D0888C8A24930D9AB"
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
    partial class MainPage : 
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
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::TrabalhoUWP.View.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.AppBarButton obj2;
            private global::Windows.UI.Xaml.Controls.SplitView obj3;
            private global::Windows.UI.Xaml.Controls.Button obj7;
            private global::Windows.UI.Xaml.Controls.Button obj8;
            private global::Windows.UI.Xaml.Controls.Button obj9;
            private global::Windows.UI.Xaml.Controls.Button obj10;
            private global::Windows.UI.Xaml.Controls.Button obj11;
            private global::Windows.UI.Xaml.Controls.ListView obj12;
            private global::Windows.UI.Xaml.Controls.MenuFlyoutItem obj13;

            private MainPage_obj1_BindingsTracking bindingsTracking;

            public MainPage_obj1_Bindings()
            {
                this.bindingsTracking = new MainPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // View\MainPage.xaml line 13
                        this.obj2 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.ViewModel.AddButton_Click();
                        };
                        break;
                    case 3: // View\MainPage.xaml line 18
                        this.obj3 = (global::Windows.UI.Xaml.Controls.SplitView)target;
                        (this.obj3).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.SplitView.IsPaneOpenProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.ViewModel.IsSplitViewOpen = this.obj3.IsPaneOpen;
                            }
                        });
                        break;
                    case 7: // View\MainPage.xaml line 55
                        this.obj7 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.ViewModel.HamburguerButton_Click();
                        };
                        break;
                    case 8: // View\MainPage.xaml line 99
                        this.obj8 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.ViewModel.AppSettingsButton_Click();
                        };
                        break;
                    case 9: // View\MainPage.xaml line 86
                        this.obj9 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.ViewModel.NovoContatoButton_Click();
                        };
                        break;
                    case 10: // View\MainPage.xaml line 76
                        this.obj10 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.ViewModel.ListaContatoFavorito_Click();
                        };
                        break;
                    case 11: // View\MainPage.xaml line 66
                        this.obj11 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.ViewModel.ListaContatoButton_Click();
                        };
                        break;
                    case 12: // View\MainPage.xaml line 116
                        this.obj12 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        ((global::Windows.UI.Xaml.Controls.ListView)target).SelectionChanged += (global::System.Object sender, global::Windows.UI.Xaml.Controls.SelectionChangedEventArgs e) =>
                        {
                            this.dataRoot.ViewModel.ListaContatos_SelectionChanged(sender, e);
                        };
                        ((global::Windows.UI.Xaml.Controls.ListView)target).RightTapped += (global::System.Object sender, global::Windows.UI.Xaml.Input.RightTappedRoutedEventArgs e) =>
                        {
                            this.dataRoot.ViewModel.ListaContatos_RightTapped(sender, e);
                        };
                        (this.obj12).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ItemsControl.ItemsSourceProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.ViewModel.ListaContatos = (global::System.Collections.Generic.List<global::TrabalhoUWP.Model.Contato>)this.obj12.ItemsSource;
                            }
                        });
                        break;
                    case 13: // View\MainPage.xaml line 140
                        this.obj13 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)target;
                        ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.ViewModel.Remove_Click();
                        };
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

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
                    this.dataRoot = (global::TrabalhoUWP.View.MainPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::TrabalhoUWP.View.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::TrabalhoUWP.ViewModel.ContatoViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_IsSplitViewOpen(obj.IsSplitViewOpen, phase);
                        this.Update_ViewModel_ListaContatos(obj.ListaContatos, phase);
                    }
                }
            }
            private void Update_ViewModel_IsSplitViewOpen(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\MainPage.xaml line 18
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_SplitView_IsPaneOpen(this.obj3, obj);
                }
            }
            private void Update_ViewModel_ListaContatos(global::System.Collections.Generic.List<global::TrabalhoUWP.Model.Contato> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\MainPage.xaml line 116
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj12, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
            private class MainPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<MainPage_obj1_Bindings> weakRefToBindingObj; 

                public MainPage_obj1_BindingsTracking(MainPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MainPage_obj1_Bindings>(obj);
                }

                public MainPage_obj1_Bindings TryGetBindingObject()
                {
                    MainPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::TrabalhoUWP.ViewModel.ContatoViewModel obj = sender as global::TrabalhoUWP.ViewModel.ContatoViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_IsSplitViewOpen(obj.IsSplitViewOpen, DATA_CHANGED);
                                bindings.Update_ViewModel_ListaContatos(obj.ListaContatos, DATA_CHANGED);
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
                                        bindings.Update_ViewModel_IsSplitViewOpen(obj.IsSplitViewOpen, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ListaContatos":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_ListaContatos(obj.ListaContatos, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::TrabalhoUWP.ViewModel.ContatoViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::TrabalhoUWP.ViewModel.ContatoViewModel obj)
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
            case 2: // View\MainPage.xaml line 13
                {
                    this.addAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 3: // View\MainPage.xaml line 18
                {
                    this.splitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 4: // View\MainPage.xaml line 22
                {
                    this.VisualStateGroupScreenWidth = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 5: // View\MainPage.xaml line 23
                {
                    this.VisualStateMinWidth700 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6: // View\MainPage.xaml line 34
                {
                    this.VisualStateMinWidth1 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 12: // View\MainPage.xaml line 116
                {
                    this.itemListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
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
            case 1: // View\MainPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}


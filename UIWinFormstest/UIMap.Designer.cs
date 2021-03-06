﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace UIWinFormstest
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// SecondRunthrough - Use 'SecondRunthroughParams' to pass parameters into this method.
        /// </summary>
        public void SecondRunthrough()
        {
            #region Variable Declarations
            WinComboBox uICmbCountriesComboBox = this.UITipCalculatorWindow.UICmbCountriesWindow.UICmbCountriesComboBox;
            WinEdit uITxtBillAmountEdit = this.UITipCalculatorWindow.UITxtBillAmountWindow.UITxtBillAmountEdit;
            WinRadioButton uIBadRadioButton = this.UITipCalculatorWindow.UIBadWindow.UIBadRadioButton;
            WinRadioButton uIItem2RadioButton = this.UITipCalculatorWindow.UIItem2Window.UIItem2RadioButton;
            WinButton uICalculateTipButton = this.UITipCalculatorWindow.UICalculateTipWindow.UICalculateTipButton;
            WinButton uICloseButton = this.UITipCalculatorWindow.UITipCalculatorTitleBar.UICloseButton;
            #endregion

            // Select 'France' in 'cmbCountries' combo box
            uICmbCountriesComboBox.SelectedItem = this.SecondRunthroughParams.UICmbCountriesComboBoxSelectedItem;

            // Type '100' in 'txtBillAmount' text box
            uITxtBillAmountEdit.Text = this.SecondRunthroughParams.UITxtBillAmountEditText;

            // Select 'Bad' radio button
            uIBadRadioButton.Selected = this.SecondRunthroughParams.UIBadRadioButtonSelected;

            // Click '2' radio button
            Mouse.Click(uIItem2RadioButton, new Point(7, 9));

            // Click 'Calculate Tip' button
            Mouse.Click(uICalculateTipButton, new Point(44, 16));

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(21, 16));
        }
        
        #region Properties
        public virtual SecondRunthroughParams SecondRunthroughParams
        {
            get
            {
                if ((this.mSecondRunthroughParams == null))
                {
                    this.mSecondRunthroughParams = new SecondRunthroughParams();
                }
                return this.mSecondRunthroughParams;
            }
        }
        
        public UITipCalculatorWindow UITipCalculatorWindow
        {
            get
            {
                if ((this.mUITipCalculatorWindow == null))
                {
                    this.mUITipCalculatorWindow = new UITipCalculatorWindow();
                }
                return this.mUITipCalculatorWindow;
            }
        }
        #endregion
        
        #region Fields
        private SecondRunthroughParams mSecondRunthroughParams;
        
        private UITipCalculatorWindow mUITipCalculatorWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'SecondRunthrough'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class SecondRunthroughParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'France' in 'cmbCountries' combo box
        /// </summary>
        public string UICmbCountriesComboBoxSelectedItem = "France";
        
        /// <summary>
        /// Type '100' in 'txtBillAmount' text box
        /// </summary>
        public string UITxtBillAmountEditText = "100";
        
        /// <summary>
        /// Select 'Bad' radio button
        /// </summary>
        public bool UIBadRadioButtonSelected = true;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UITipCalculatorWindow : WinWindow
    {
        
        public UITipCalculatorWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Tip Calculator";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Tip Calculator");
            #endregion
        }
        
        #region Properties
        public UICmbCountriesWindow UICmbCountriesWindow
        {
            get
            {
                if ((this.mUICmbCountriesWindow == null))
                {
                    this.mUICmbCountriesWindow = new UICmbCountriesWindow(this);
                }
                return this.mUICmbCountriesWindow;
            }
        }
        
        public UITxtBillAmountWindow UITxtBillAmountWindow
        {
            get
            {
                if ((this.mUITxtBillAmountWindow == null))
                {
                    this.mUITxtBillAmountWindow = new UITxtBillAmountWindow(this);
                }
                return this.mUITxtBillAmountWindow;
            }
        }
        
        public UIBadWindow UIBadWindow
        {
            get
            {
                if ((this.mUIBadWindow == null))
                {
                    this.mUIBadWindow = new UIBadWindow(this);
                }
                return this.mUIBadWindow;
            }
        }
        
        public UIItem2Window UIItem2Window
        {
            get
            {
                if ((this.mUIItem2Window == null))
                {
                    this.mUIItem2Window = new UIItem2Window(this);
                }
                return this.mUIItem2Window;
            }
        }
        
        public UICalculateTipWindow UICalculateTipWindow
        {
            get
            {
                if ((this.mUICalculateTipWindow == null))
                {
                    this.mUICalculateTipWindow = new UICalculateTipWindow(this);
                }
                return this.mUICalculateTipWindow;
            }
        }
        
        public UITipCalculatorTitleBar UITipCalculatorTitleBar
        {
            get
            {
                if ((this.mUITipCalculatorTitleBar == null))
                {
                    this.mUITipCalculatorTitleBar = new UITipCalculatorTitleBar(this);
                }
                return this.mUITipCalculatorTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UICmbCountriesWindow mUICmbCountriesWindow;
        
        private UITxtBillAmountWindow mUITxtBillAmountWindow;
        
        private UIBadWindow mUIBadWindow;
        
        private UIItem2Window mUIItem2Window;
        
        private UICalculateTipWindow mUICalculateTipWindow;
        
        private UITipCalculatorTitleBar mUITipCalculatorTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UICmbCountriesWindow : WinWindow
    {
        
        public UICmbCountriesWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "cmbCountries";
            this.WindowTitles.Add("Tip Calculator");
            #endregion
        }
        
        #region Properties
        public WinComboBox UICmbCountriesComboBox
        {
            get
            {
                if ((this.mUICmbCountriesComboBox == null))
                {
                    this.mUICmbCountriesComboBox = new WinComboBox(this);
                    #region Search Criteria
                    this.mUICmbCountriesComboBox.SearchProperties[WinComboBox.PropertyNames.Name] = "cmbCountries";
                    this.mUICmbCountriesComboBox.WindowTitles.Add("Tip Calculator");
                    #endregion
                }
                return this.mUICmbCountriesComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WinComboBox mUICmbCountriesComboBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UITxtBillAmountWindow : WinWindow
    {
        
        public UITxtBillAmountWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtBillAmount";
            this.WindowTitles.Add("Tip Calculator");
            #endregion
        }
        
        #region Properties
        public WinEdit UITxtBillAmountEdit
        {
            get
            {
                if ((this.mUITxtBillAmountEdit == null))
                {
                    this.mUITxtBillAmountEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITxtBillAmountEdit.WindowTitles.Add("Tip Calculator");
                    #endregion
                }
                return this.mUITxtBillAmountEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITxtBillAmountEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIBadWindow : WinWindow
    {
        
        public UIBadWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "rdbBad";
            this.WindowTitles.Add("Tip Calculator");
            #endregion
        }
        
        #region Properties
        public WinRadioButton UIBadRadioButton
        {
            get
            {
                if ((this.mUIBadRadioButton == null))
                {
                    this.mUIBadRadioButton = new WinRadioButton(this);
                    #region Search Criteria
                    this.mUIBadRadioButton.SearchProperties[WinRadioButton.PropertyNames.Name] = "Bad";
                    this.mUIBadRadioButton.WindowTitles.Add("Tip Calculator");
                    #endregion
                }
                return this.mUIBadRadioButton;
            }
        }
        #endregion
        
        #region Fields
        private WinRadioButton mUIBadRadioButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItem2Window : WinWindow
    {
        
        public UIItem2Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "rdb2NumCourses";
            this.WindowTitles.Add("Tip Calculator");
            #endregion
        }
        
        #region Properties
        public WinRadioButton UIItem2RadioButton
        {
            get
            {
                if ((this.mUIItem2RadioButton == null))
                {
                    this.mUIItem2RadioButton = new WinRadioButton(this);
                    #region Search Criteria
                    this.mUIItem2RadioButton.SearchProperties[WinRadioButton.PropertyNames.Name] = "2";
                    this.mUIItem2RadioButton.WindowTitles.Add("Tip Calculator");
                    #endregion
                }
                return this.mUIItem2RadioButton;
            }
        }
        #endregion
        
        #region Fields
        private WinRadioButton mUIItem2RadioButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UICalculateTipWindow : WinWindow
    {
        
        public UICalculateTipWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "button1";
            this.WindowTitles.Add("Tip Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UICalculateTipButton
        {
            get
            {
                if ((this.mUICalculateTipButton == null))
                {
                    this.mUICalculateTipButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICalculateTipButton.SearchProperties[WinButton.PropertyNames.Name] = "Calculate Tip";
                    this.mUICalculateTipButton.WindowTitles.Add("Tip Calculator");
                    #endregion
                }
                return this.mUICalculateTipButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICalculateTipButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UITipCalculatorTitleBar : WinTitleBar
    {
        
        public UITipCalculatorTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Tip Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("Tip Calculator");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
}

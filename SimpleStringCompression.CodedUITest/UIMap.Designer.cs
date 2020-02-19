﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      Этот код был создан построителем кодированных тестов ИП.
//      Версия: 16.0.0.0
//
//      Изменения, внесенные в этот файл, могут привести к неправильной работе кода и будут
//      утрачены при повторном формировании кода.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace SimpleStringCompression.CodedUITest
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


    [GeneratedCode("Построитель кодированных тестов ИП", "16.0.28315.86")]
    public partial class UIMap
    {

        /// <summary>
        /// RecordedMethod1 - Используйте "RecordedMethod1Params" для передачи параметров в этот метод.
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinEdit uITextInputEdit = this.UIStringCompressorWindow1.UITextInputWindow.UITextInputEdit;
            WinButton uIСжатьButton = this.UIStringCompressorWindow1.UIСжатьWindow.UIСжатьButton;
            WinButton uIОчиститьButton = this.UIStringCompressorWindow1.UIОчиститьWindow.UIОчиститьButton;
            #endregion

            // Тип "" в "textInput" надпись
            uITextInputEdit.Text = this.RecordedMethod1Params.UITextInputEditText;

            // Тип "тест" в "textInput" надпись
            uITextInputEdit.Text = this.RecordedMethod1Params.UITextInputEditText1;

            // Щелкните "Сжать" кнопка
            Mouse.Click(uIСжатьButton, new Point(67, 13));

            // Щелкните "Очистить" кнопка
            Mouse.Click(uIОчиститьButton, new Point(29, 16));

            Assert.IsTrue(string.IsNullOrEmpty(uITextInputEdit.Text));
        }

        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }

        public UIStringCompressorWindow UIStringCompressorWindow
        {
            get
            {
                if ((this.mUIStringCompressorWindow == null))
                {
                    this.mUIStringCompressorWindow = new UIStringCompressorWindow();
                }
                return this.mUIStringCompressorWindow;
            }
        }

        public UIStringCompressorWindow1 UIStringCompressorWindow1
        {
            get
            {
                if ((this.mUIStringCompressorWindow1 == null))
                {
                    this.mUIStringCompressorWindow1 = new UIStringCompressorWindow1();
                }
                return this.mUIStringCompressorWindow1;
            }
        }
        #endregion

        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;

        private UIStringCompressorWindow mUIStringCompressorWindow;

        private UIStringCompressorWindow1 mUIStringCompressorWindow1;
        #endregion
    }

    /// <summary>
    /// Параметры для передачи в "RecordedMethod1"
    /// </summary>
    [GeneratedCode("Построитель кодированных тестов ИП", "16.0.28315.86")]
    public class RecordedMethod1Params
    {

        #region Fields
        /// <summary>
        /// Тип "" в "textInput" надпись
        /// </summary>
        public string UITextInputEditText = "";

        /// <summary>
        /// Тип "тест" в "textInput" надпись
        /// </summary>
        public string UITextInputEditText1 = "тест";
        #endregion
    }

    [GeneratedCode("Построитель кодированных тестов ИП", "16.0.28315.86")]
    public class UIStringCompressorWindow : WinWindow
    {

        public UIStringCompressorWindow()
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.Name] = "StringCompressor";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("StringCompressor");
            #endregion
        }

        #region Properties
        public UITextInputWindow UITextInputWindow
        {
            get
            {
                if ((this.mUITextInputWindow == null))
                {
                    this.mUITextInputWindow = new UITextInputWindow(this);
                }
                return this.mUITextInputWindow;
            }
        }
        #endregion

        #region Fields
        private UITextInputWindow mUITextInputWindow;
        #endregion
    }

    [GeneratedCode("Построитель кодированных тестов ИП", "16.0.28315.86")]
    public class UITextInputWindow : WinWindow
    {

        public UITextInputWindow(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "textInput";
            this.WindowTitles.Add("StringCompressor");
            #endregion
        }

        #region Properties
        public WinEdit UITextInputEdit
        {
            get
            {
                if ((this.mUITextInputEdit == null))
                {
                    this.mUITextInputEdit = new WinEdit(this);
                    #region Условия поиска
                    this.mUITextInputEdit.WindowTitles.Add("StringCompressor");
                    #endregion
                }
                return this.mUITextInputEdit;
            }
        }
        #endregion

        #region Fields
        private WinEdit mUITextInputEdit;
        #endregion
    }

    [GeneratedCode("Построитель кодированных тестов ИП", "16.0.28315.86")]
    public class UIStringCompressorWindow1 : WinWindow
    {

        public UIStringCompressorWindow1()
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.Name] = "StringCompressor";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.FilterProperties[WinWindow.PropertyNames.OrderOfInvocation] = "2";
            this.WindowTitles.Add("StringCompressor");
            #endregion
        }

        #region Properties
        public UITextInputWindow1 UITextInputWindow
        {
            get
            {
                if ((this.mUITextInputWindow == null))
                {
                    this.mUITextInputWindow = new UITextInputWindow1(this);
                }
                return this.mUITextInputWindow;
            }
        }

        public UIСжатьWindow UIСжатьWindow
        {
            get
            {
                if ((this.mUIСжатьWindow == null))
                {
                    this.mUIСжатьWindow = new UIСжатьWindow(this);
                }
                return this.mUIСжатьWindow;
            }
        }

        public UIОчиститьWindow UIОчиститьWindow
        {
            get
            {
                if ((this.mUIОчиститьWindow == null))
                {
                    this.mUIОчиститьWindow = new UIОчиститьWindow(this);
                }
                return this.mUIОчиститьWindow;
            }
        }
        #endregion

        #region Fields
        private UITextInputWindow1 mUITextInputWindow;

        private UIСжатьWindow mUIСжатьWindow;

        private UIОчиститьWindow mUIОчиститьWindow;
        #endregion
    }

    [GeneratedCode("Построитель кодированных тестов ИП", "16.0.28315.86")]
    public class UITextInputWindow1 : WinWindow
    {

        public UITextInputWindow1(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "textInput";
            this.WindowTitles.Add("StringCompressor");
            #endregion
        }

        #region Properties
        public WinEdit UITextInputEdit
        {
            get
            {
                if ((this.mUITextInputEdit == null))
                {
                    this.mUITextInputEdit = new WinEdit(this);
                    #region Условия поиска
                    this.mUITextInputEdit.WindowTitles.Add("StringCompressor");
                    #endregion
                }
                return this.mUITextInputEdit;
            }
        }
        #endregion

        #region Fields
        private WinEdit mUITextInputEdit;
        #endregion
    }

    [GeneratedCode("Построитель кодированных тестов ИП", "16.0.28315.86")]
    public class UIСжатьWindow : WinWindow
    {

        public UIСжатьWindow(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "button2";
            this.WindowTitles.Add("StringCompressor");
            #endregion
        }

        #region Properties
        public WinButton UIСжатьButton
        {
            get
            {
                if ((this.mUIСжатьButton == null))
                {
                    this.mUIСжатьButton = new WinButton(this);
                    #region Условия поиска
                    this.mUIСжатьButton.SearchProperties[WinButton.PropertyNames.Name] = "Сжать";
                    this.mUIСжатьButton.WindowTitles.Add("StringCompressor");
                    #endregion
                }
                return this.mUIСжатьButton;
            }
        }
        #endregion

        #region Fields
        private WinButton mUIСжатьButton;
        #endregion
    }

    [GeneratedCode("Построитель кодированных тестов ИП", "16.0.28315.86")]
    public class UIОчиститьWindow : WinWindow
    {

        public UIОчиститьWindow(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "button1";
            this.WindowTitles.Add("StringCompressor");
            #endregion
        }

        #region Properties
        public WinButton UIОчиститьButton
        {
            get
            {
                if ((this.mUIОчиститьButton == null))
                {
                    this.mUIОчиститьButton = new WinButton(this);
                    #region Условия поиска
                    this.mUIОчиститьButton.SearchProperties[WinButton.PropertyNames.Name] = "Очистить";
                    this.mUIОчиститьButton.WindowTitles.Add("StringCompressor");
                    #endregion
                }
                return this.mUIОчиститьButton;
            }
        }
        #endregion

        #region Fields
        private WinButton mUIОчиститьButton;
        #endregion
    }
}
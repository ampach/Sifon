﻿using System.ComponentModel;
using System.Windows.Forms;
using Sifon.Abstractions.Validation;
using Sifon.Shared.MessageBoxes;
using Sifon.Shared.Validation;

namespace Sifon.Forms.Base
{
    [TypeDescriptionProvider(typeof(ConcreteClassProvider))]
    internal abstract partial class AbstractForm : Form, IFormValidation
    {
        protected AbstractForm()
        {
            // Avoid putting any custom code within this ctor, otherwise designers stops working
            InitializeComponent();

            _displayMessage = new DisplayMessage();
            _formValidation = new FormValidation(_displayMessage);

            Load += (sender, args) => SetTooltips();
            Load += (sender, args) => AddPassiveValidationHandlers();
        }

        protected virtual void SetTooltips()
        {
        }
        
        #region ESC button closes dialog as OK

        public virtual void CloseDialog()
        {
            DialogResult = DialogResult.OK;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                CloseDialog();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
    }
}

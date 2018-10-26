﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Invoker
{
    /// <summary>
    /// To use this class / functions you should inheritance (erben) this class in the class you want to use it.
    /// </summary>
    public class WinForms_Invoker : UserControl
    {
        private delegate void setEnableHandler(object target, bool enable);
        /// <summary>
        /// Set the enable state of the given object GUI-thread-save using invoke.
        /// </summary>
        /// <param name="target">The object that should be enabled. Check if the object type is supported...</param>
        /// <param name="enable">The enable state that is to be set</param>
        protected void setEnable(object target, bool enable)
        {
            if (target == null)
            {
                return;
            }

            if (this.InvokeRequired) //me is an objekt of aktual Form
            {
                Invoke(new setEnableHandler(setEnable), new object[] { target, enable });
                return;
            }

            //set content - switch by type
            if (target.GetType() == typeof(Button))
            {
                ((Button)target).Enabled = enable;
            }
            else if (target.GetType() == typeof(TextBox))
            {
                ((TextBox)target).Enabled = enable;
            }
            else if (target.GetType() == typeof(CheckBox))
            {
                ((CheckBox)target).Enabled = enable;
            }
            else if (target.GetType() == typeof(CheckedListBox))
            {
                ((CheckedListBox)target).Enabled = enable;
            }
            else
            {
                throw new NotSupportedException("iotec.GUI.Common - setEnable(..): ERROR: The objecttype is not supported! Please add the object type to the setEnable() Functiuon.");
            }
        }

        private delegate void setVisibleHandler(object target, bool enable);
        /// <summary>
        /// Set the vivible state of the given object GUI-thread-save using invoke.
        /// </summary>
        /// <param name="target">The object that should be enabled. Check if the object type is supported...</param>
        /// <param name="enable">The visible state that is to be set</param>
        protected void setVisible(object target, bool visible)
        {
            if (target == null)
            {
                return;
            }

            if (this.InvokeRequired) //me is an objekt of aktual Form
            {
                Invoke(new setVisibleHandler(setVisible), new object[] { target, visible });
                return;
            }

            //set content - switch by type
            if (target.GetType() == typeof(Button))
            {
                ((Button)target).Visible = visible;
            }
            else if (target.GetType() == typeof(TextBox))
            {
                ((TextBox)target).Visible = visible;
            }
            else if (target.GetType() == typeof(CheckBox))
            {
                ((CheckBox)target).Visible = visible;
            }
            else if (target.GetType() == typeof(CheckedListBox))
            {
                ((CheckedListBox)target).Visible = visible;
            }
            else if (target.GetType() == typeof(ListBox))
            {
                ((ListBox)target).Visible = visible;
            }
            else if (target.GetType() == typeof(PictureBox))
            {
                ((PictureBox)target).Visible = visible;
            }
            else
            {
                throw new NotSupportedException("iotec.GUI.Common - setVisible(..): ERROR: The objecttype is not supported! Please add the object type to the setVisible() Functiuon.");
            }
        }

        
    }
}

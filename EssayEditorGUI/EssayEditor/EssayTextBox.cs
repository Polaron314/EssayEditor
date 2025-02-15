﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EssayEditor
{
    public class EssayTextBox : RichTextBox
    {
        private Timer m_delayedTextChangedTimer;

        public event EventHandler DelayedTextChanged;

        int DelayedTextChangedTimeout = 3 * 1000; // 5 seconds

        public bool shouldRun { get; set; }

        public EssayTextBox() : base()
        {
            this.shouldRun = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (m_delayedTextChangedTimer != null)
            {
                m_delayedTextChangedTimer.Stop();
                if (disposing)
                    m_delayedTextChangedTimer.Dispose();
            }

            base.Dispose(disposing);
        }

        protected virtual void OnDelayedTextChanged(EventArgs e)
        {
            if (this.DelayedTextChanged != null)
                this.DelayedTextChanged(this, e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            this.InitializeDelayedTextChangedEvent();
            base.OnTextChanged(e);
        }

        private void InitializeDelayedTextChangedEvent()
        {
            if (this.shouldRun)
            {
                if (m_delayedTextChangedTimer != null)
                    m_delayedTextChangedTimer.Stop();

                m_delayedTextChangedTimer = new Timer();
                m_delayedTextChangedTimer.Tick += new EventHandler(HandleDelayedTextChangedTimerTick);
                m_delayedTextChangedTimer.Interval = this.DelayedTextChangedTimeout;

                m_delayedTextChangedTimer.Start();
            }
        }

        private void HandleDelayedTextChangedTimerTick(object sender, EventArgs e)
        {
            Timer timer = sender as Timer;
            timer.Stop();

            this.OnDelayedTextChanged(EventArgs.Empty);
        }
    }
}

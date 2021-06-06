using System.Windows.Forms;
using FacebookDeskAppLogic;

namespace FacebookDeskAppUI
{
    public class UIFacade
    {
        // Data Members
        private LoginForm m_LoginForm;
        private MainForm m_MainForm;

        // Ctor
        public UIFacade()
        {
        }

        // Public Methods
        public void Run()
        {
            m_LoginForm = new LoginForm();
            m_MainForm = new MainForm();
            m_MainForm.FormClosing += saveSettingsIfNeeded;
            m_LoginForm.ShowDialog();
            m_MainForm.InitFormDetails();
            m_MainForm.ShowDialog();
        }

        // Private Methods
        private void saveSettingsIfNeeded(object sender, FormClosingEventArgs e)
        {
            if(m_MainForm.IsRememberSettingsChecked())
            {
                FacebookServiceProxy.Logout();
            }
        }
    }
}
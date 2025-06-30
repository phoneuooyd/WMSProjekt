using System;
using System.Reflection;
using System.Windows.Forms;
using WMS___Projekt.Forms;
using WMS___Projekt.Utillities;
using Xunit;

namespace WMS___Projekt.Tests
{
    public class LoginFormTests
    {
        [Fact]
        public void LoginButton_Click_WithValidCredentials_ShouldCloseLoginFormAndShowMainForm()
        {
            // Arrange
            LoginForm loginForm = new LoginForm();
            string validServerName = "example.com";
            string validDatabaseName = "TestDB";
            string validLogin = "user";
            string validPassword = "password";
            bool isWindowsAuth = false;

            // Access private fields using reflection
            PropertyInfo serverNameComboBoxProperty = loginForm.GetType().GetProperty("serverNameComboBox", BindingFlags.NonPublic | BindingFlags.Instance);
            PropertyInfo databaseNameTextboxProperty = loginForm.GetType().GetProperty("databaseNameTextbox", BindingFlags.NonPublic | BindingFlags.Instance);
            PropertyInfo loginTextboxProperty = loginForm.GetType().GetProperty("loginTextbox", BindingFlags.NonPublic | BindingFlags.Instance);
            PropertyInfo passwordTextboxProperty = loginForm.GetType().GetProperty("passwordTextbox", BindingFlags.NonPublic | BindingFlags.Instance);
            PropertyInfo isWindowsAuthenticationCheckboxProperty = loginForm.GetType().GetProperty("isWindowsAuthenticationCheckbox", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodInfo loginButtonClickMethod = loginForm.GetType().GetMethod("loginButton_Click", BindingFlags.NonPublic | BindingFlags.Instance);

            // Set private fields
            ((ComboBox)serverNameComboBoxProperty.GetValue(loginForm)).Text = validServerName;
            ((TextBox)databaseNameTextboxProperty.GetValue(loginForm)).Text = validDatabaseName;
            ((TextBox)loginTextboxProperty.GetValue(loginForm)).Text = validLogin;
            ((TextBox)passwordTextboxProperty.GetValue(loginForm)).Text = validPassword;
            ((CheckBox)isWindowsAuthenticationCheckboxProperty.GetValue(loginForm)).Checked = isWindowsAuth;

            // Act: Invoke the private method loginButton_Click
            loginButtonClickMethod.Invoke(loginForm, new object[] { null, EventArgs.Empty });

            // Assert
            Assert.False(loginForm.Visible); // Check if the login form is closed
            Assert.Empty(FormManager.openForms); // Check if all forms are closed
            Assert.IsType<MainForm>(FormManager.openForms[0]); // Check if the first open form is the main form
        }

        // Add more tests for invalid credentials, edge cases, etc.
    }
}

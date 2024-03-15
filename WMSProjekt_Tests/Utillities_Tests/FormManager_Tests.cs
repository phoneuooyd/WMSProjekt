using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // Add reference to System.Windows.Forms for Form class
using Xunit;
using WMS___Projekt.Forms;
using WMS___Projekt.Utillities;

namespace WMS___Projekt.Tests
{
    public class FormManagerTests
    {
        [Fact]
        public void ShowForm_AddsFormToList()
        {
            // Arrange
            Form form = new Form(); // Create a new Form instance
            int initialCount = FormManager.openForms.Count; // Get initial count of openForms

            // Act
            FormManager.ShowForm(form); // Call the ShowForm method

            // Assert
            Assert.Contains(form, FormManager.openForms); // Check if the form was added to the list
            Assert.Equal(initialCount + 1, FormManager.openForms.Count); // Check if the count increased by 1
        }

        [Fact]
        public void CloseAllForms_DisposesAllForms()
        {
            // Arrange
            Form form1 = new Form();
            Form form2 = new Form();
            FormManager.openForms.Add(form1);
            FormManager.openForms.Add(form2);

            // Act
            FormManager.CloseAllForms();

            // Assert
            Assert.Empty(FormManager.openForms); // Check if openForms list is empty after closing
            Assert.True(form1.IsDisposed); // Check if form1 was disposed
            Assert.True(form2.IsDisposed); // Check if form2 was disposed
        }
    }
}

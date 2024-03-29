﻿
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace mpvgui.Windows.WPF;

public partial class SearchTextBoxUserControl : UserControl
{
    public bool HideClearButton { get; set; }

    public SearchTextBoxUserControl()
    {
        InitializeComponent();
        DataContext = this;
    }

    public Theme? Theme => Theme.Current;

    public string Text {
        get => SearchTextBox.Text;
        set => SearchTextBox.Text = value;
    }

    string? _hintText;

    public string? HintText {
        get => _hintText;
        set {
            _hintText = value;
            UpdateControls();
        }
    }

    void SearchClearButton_Click(object sender, RoutedEventArgs e)
    {
        SearchTextBox.Text = "";
        Keyboard.Focus(SearchTextBox);
    }

    void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        UpdateControls();
    }

    void UpdateControls()
    {
        HintTextBlock.Text = SearchTextBox.Text == "" ? HintText : "";

        if (SearchTextBox.Text == "" || HideClearButton)
            SearchClearButton.Visibility = Visibility.Hidden;
        else
            SearchClearButton.Visibility = Visibility.Visible;
    }
}

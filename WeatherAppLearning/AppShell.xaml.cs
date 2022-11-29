﻿namespace WeatherAppLearning;

public partial class AppShell : Shell
{
	public AppShell(AppShellViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;
        FlyoutBackground.BindingContext = viewModel;

        viewModel.IsActive = true;
    }
}
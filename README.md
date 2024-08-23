# How to change the colors of the CheckBox and input background depending on light and dark theme mode.
In this article, we will show you how to change the colors of the CheckBox and input background depending on light and dark theme mode in [.Net Maui DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

## C#
The below code illustrates how to change the colors of the CheckBox and input background depending on light and dark theme mode in DataGrid.
```
public MainPage()
{
    InitializeComponent();
    ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;

    if (mergedDictionaries != null)
    {

        var theme = mergedDictionaries.OfType<SyncfusionThemeResourceDictionary>().FirstOrDefault();
        if (theme != null)
        {
            if (theme.VisualTheme is SfVisuals.MaterialDark)
            {
                sfGrid.DefaultStyle.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "CheckBoxColor").SetValue(sfGrid.DefaultStyle, Colors.Yellow);
                sfGrid.DefaultStyle.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "InputBackgroundColor").SetValue(sfGrid.DefaultStyle, Colors.SkyBlue);
            }
            else
            {
                sfGrid.DefaultStyle.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "CheckBoxColor").SetValue(sfGrid.DefaultStyle, Colors.Orange);
                sfGrid.DefaultStyle.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "InputBackgroundColor").SetValue(sfGrid.DefaultStyle, Colors.Green);
            }

        }
        else
        {
            sfGrid.DefaultStyle.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "CheckBoxColor").SetValue(sfGrid.DefaultStyle, Colors.Orange);
            sfGrid.DefaultStyle.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name == "InputBackgroundColor").SetValue(sfGrid.DefaultStyle, Colors.Green);
        }
    }
}
```
**Light Theme**
 ![LightTheme.png](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI4NTk3Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.XrFfMptVubP4auRAAELo-raOUYQVcKuYOKbNVVAoBpA)

**Dark Theme**
 ![DarkTheme.png](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI4NTk4Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.21TQk3C8-OxVFcFU78q5ZkH9_mnNKvwRtOsBENb1w9g)


[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-change-the-colors-of-the-CheckBox-and-input-background-depending-on-light-and-dark-mode)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to change the colors of the CheckBox and input background depending on light and dark theme mode in .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!
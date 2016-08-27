# XamarinFormsListViewSample
Sample: Using ListView on Xamarin.Forms

## 参考
- [Xamarin.FormsでListViewコントロールを使用するには？ - Build Insider](http://www.buildinsider.net/mobile/xamarintips/0038)

## Pickuped code
### [Page1.cs](XamarinFormsListView/XamarinFormsListView/Page1.cs)
```
public class Page1 : ContentPage
{
    public Page1()
    {
        // Make Collection
        var ar = new ObservableCollection<string>();
        foreach (var i in Enumerable.Range(0, 100))
        {
            ar.Add(string.Format("hoge-{0}", i));
        }

        // Make ListView
        var listView = new ListView
        {
            ItemsSource = ar
        };

        // Make Layout
        Content = new StackLayout
        {
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
            Children = {
                ....,
                listView
            }
        };
    }
}
```

## Screenshot
![screenshot](https://raw.githubusercontent.com/xamarin-samples/XamarinFormsListViewSample/master/screenshots/screenshot.png)

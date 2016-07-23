using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinFormsListView
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            // 参考：http://www.buildinsider.net/mobile/xamarintips/0038

            // リスト作成.
            var ar = new ObservableCollection<string>();
            foreach (var i in Enumerable.Range(0, 100))
            {
                ar.Add(string.Format("hoge-{0}", i));
            }

            // リストビュー作成.
            var listView = new ListView
            {
                ItemsSource = ar
            };

            Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0), // iOSのみ上部にマージンをとる.
                Children = {
                    new Frame
                    {
                        Padding = new Thickness(10, 10, 10, 10),
                        OutlineColor = new Color(1.0, 0.0, 0.0), // 赤枠
                        BackgroundColor=new Color(1.0, 0.8, 0.8), // ピンク背景
                        Content = new Label {
                            Text = "Hello ContentPage!!!!!!!!!",
                            TextColor =new Color(0.0,0.0,0.0) // 黒文字
                        }
                    },
                    listView
                }
            };
        }
    }
}

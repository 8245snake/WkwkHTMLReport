using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.OffScreen;

namespace WkwkReportServer.Printing
{
    public class PDFCreator
    {
        private static bool _IsCefInitialized = false;
        private static string ExeDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        private string _CachePath;

        /// <summary>
        /// PDF作成用インスタンスを作る
        /// </summary>
        /// <param name="cachePath">キャッシュファイルの保存先（省略時は実行ファイルと同階層のcacheフォルダ）</param>
        public PDFCreator(string cachePath = null)
        {
            if (string.IsNullOrWhiteSpace(cachePath))
            {
                _CachePath = Path.Combine(ExeDirectory, "cache");
            }
            else
            {
                _CachePath = cachePath;
            }
        }


        /// <summary>
        /// CEFを初期する
        /// </summary>
        /// <remarks>プログラムの開始時に呼ぶこと</remarks>
        public static void InitCef()
        {
            if (_IsCefInitialized == false)
            {
                CefSettings settings = new CefSettings();
                settings.Locale = "ja";
                settings.AcceptLanguageList = "ja-JP";
                Cef.Initialize(settings, performDependencyCheck: false, browserProcessHandler: null);
                _IsCefInitialized = true;
            }
        }

        /// <summary>
        /// CEFを終了する
        /// </summary>
        /// <remarks>プログラムの終了時に呼ぶこと</remarks>
        public static void CloseCef()
        {
            Cef.Shutdown();
        }

        private ChromiumWebBrowser CreateBrowser(string url, string cachePath)
        {
            var browserSettings = new BrowserSettings();
            browserSettings.WindowlessFrameRate = 1;
            var requestContextSettings = new RequestContextSettings { CachePath = cachePath };
            var requestContext = new RequestContext(requestContextSettings);
            return new ChromiumWebBrowser(url, browserSettings, requestContext);
        }

        /// <summary>
        /// PDFファイルを出力する
        /// </summary>
        /// <param name="url">印刷対象のURL</param>
        /// <param name="outputPath">PDFファイルの出力先パス</param>
        /// <returns>成功したか</returns>
        public async Task<bool> CreatePDFAsync(string url, string outputPath)
        {
            if (_IsCefInitialized == false)
            {
                InitCef();
            }
            return await PrintToPdfAsync(url, outputPath);
        }

        public async void PrintDialog(string url)
        {
            if (_IsCefInitialized == false)
            {
                InitCef();
            }

            var browser = CreateBrowser(url, _CachePath);
            // ページ読み込みが終了するまで待機
            await LoadPageAsync(browser);
            // PDF保存
            browser.Print();
            browser.Dispose();
        }

        /// <summary>
        /// 指定したURLのページをPDFに保存する
        /// </summary>
        /// <param name="url"></param>
        /// <param name="outputPath"></param>
        /// <returns></returns>
        private async Task<bool> PrintToPdfAsync(string url, string outputPath)
        {
            using (var browser = CreateBrowser(url, _CachePath))
            {
                // ページ読み込みが終了するまで待機
                await LoadPageAsync(browser);
                // PDF保存
                return await browser.PrintToPdfAsync(outputPath);
            }
        }

        /// <summary>
        /// 非同期でページを読み込む
        /// </summary>
        /// <param name="browser">ブラウザ</param>
        /// <param name="url">URL</param>
        /// <returns></returns>
        public Task LoadPageAsync(IWebBrowser browser, string url = null)
        {
            var tcs = new TaskCompletionSource<bool>();

            EventHandler<LoadingStateChangedEventArgs> handler = null;
            handler = (sender, args) =>
            {
                if (!args.IsLoading)
                {
                    browser.LoadingStateChanged -= handler;
                    tcs.TrySetResult(true);
                }
            };

            browser.LoadingStateChanged += handler;

            if (!string.IsNullOrEmpty(url))
            {
                browser.Load(url);
            }
            return tcs.Task;
        }

    }
}

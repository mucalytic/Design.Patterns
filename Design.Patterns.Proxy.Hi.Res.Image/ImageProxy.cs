using Design.Patterns.Proxy.Hi.Res.Image.Interfaces;
using Microsoft.Reactive.Testing;
using System.Reactive.Linq;
using Xunit.Abstractions;

namespace Design.Patterns.Proxy.Hi.Res.Image;

public class ImageProxy(ITestOutputHelper helper, TestScheduler scheduler, string filename) : IImage
{
    private readonly Image _lowResImage = new(helper, $"low-res-{filename}");

    private IDisposable? _imageLoader;
    private Image? _realImage;
    private bool _loading;

    private IObservable<Image> ImageLoader =>
        Observable.Return(new Image(helper, filename), scheduler)
                  .Delay(TimeSpan.FromSeconds(3), scheduler);

    public void Display()
    {
        if (_realImage is not null)
        {
            _realImage.Display();
            return;
        }
        if (!_loading)
        {
            _loading = true;
            _imageLoader = ImageLoader.Subscribe(image =>
            {
                _realImage = image;
                _loading = false;
            });
        }
        _lowResImage.Display();
    }

    public void Dispose() =>
        _imageLoader?.Dispose();
}

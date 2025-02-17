using MapKit;

namespace HelloWorld;

public class TestTileOverlay: MKTileOverlay
{
    public override void LoadTileAtPath(MKTileOverlayPath path, 
        /*[BlockProxy(typeof(NIDMKTileOverlayLoadTileCompletionHandler))]*/ MKTileOverlayLoadTileCompletionHandler result)
    {
        result(new Foundation.NSData(), null);
    }
}

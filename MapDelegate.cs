using MapKit;

namespace HelloWorld;

public class MapDelegate : MKMapViewDelegate
{
    public override MKOverlayRenderer OverlayRenderer(MKMapView mapView, IMKOverlay overlay)
    {
        if (overlay is TestTileOverlay localTileOverlay)
        {
            return new MKTileOverlayRenderer(localTileOverlay);
        }
        return null;
    }
}
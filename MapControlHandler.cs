using MapKit;
using Microsoft.Maui.Handlers;

namespace HelloWorld;

public partial class MapControlHandler : ViewHandler<MapControl, MKMapView>
{
    public static PropertyMapper<MapControl, MapControlHandler> PropertyMapper = new PropertyMapper<MapControl, MapControlHandler>(ViewMapper)
    {
    };

    public MapControlHandler() : base(PropertyMapper, null)
    {
    }

    protected override MKMapView CreatePlatformView()
    {
        var mapView = new MKMapView() { Delegate = new MapDelegate()};
      
        mapView.AddOverlay(new TestTileOverlay() { });
        return mapView;
    }

    protected override void ConnectHandler(MKMapView platformView)
    {
        base.ConnectHandler(platformView);
    }

    protected override void DisconnectHandler(MKMapView platformView)
    {
        base.DisconnectHandler(platformView);
    }
}

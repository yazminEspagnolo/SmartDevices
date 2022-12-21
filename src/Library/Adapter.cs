namespace AdapterExample;
/// <summary>
/// Adaptador de Plug a un SmartDevice
/// </summary>
public class Adapter : ISmartDevice
{
    /// <summary>
    /// Constructor al que se le pasa un Plug como parámetro.
    /// </summary>
    /// <param name="plug"></param>
    public Adapter(Plug plug)
    {
        this.AdaptPlug = plug;
    }

    /// <summary>
    /// El plug que se adapta.
    /// </summary>
    public Plug AdaptPlug { get; set; }

    /// <summary>
    /// Se prende el dispositivo si está apagado.
    /// </summary>
    public void On()
    {
        if (AdaptPlug.GetStatus() == "off")
        {
            AdaptPlug.ToggleStatus();
        }
    }

    /// <summary>
    /// Se apaga el dispositivo si está prendido.
    /// </summary>
    public void Off()
    {
        if (AdaptPlug.GetStatus() == "on")
        {
            AdaptPlug.ToggleStatus();
        }
    }

    /// <summary>
    /// Retorna el estado del dispositivo.
    /// </summary>
    public string GetStatus()
    {
        return AdaptPlug.GetStatus();
    }
}
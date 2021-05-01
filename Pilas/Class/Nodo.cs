class Nodo{
    private int dato;
    private Nodo siguiente = null;

    public int Dato{
        get => dato;
        set => dato = value;
    }    

    internal Nodo Siguiente{
        get => siguiente;
        set => siguiente = value;
    }

    //Método que permita usar el writeline y se muestre de una forma lo que se imprime
    //Presentación
    public override string ToString()
    {
        return string.Format("[{0}]", dato);
    }
}
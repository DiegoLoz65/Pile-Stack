using System;

class Stack{
    private Nodo cabecera;
    private Nodo referencia;
    
    public Stack(){
        cabecera = new Nodo();
        cabecera.Siguiente = null;
    }

    //Push
    public void Push(int pDato){
        Nodo tmp = new Nodo();
        tmp.Dato = pDato;
        tmp.Siguiente  = cabecera.Siguiente;
        cabecera.Siguiente = tmp;
    }

    //Pop
    public int Pop(){
        int valor = 0;
        if (cabecera.Siguiente != null){
            referencia = cabecera.Siguiente;
            valor = referencia.Dato;

            cabecera.Siguiente = referencia.Siguiente;
            referencia.Siguiente = null;
        }
        return valor;
    }

    //Peek
    public int Peek(){
        int valor = 0;
        if (cabecera.Siguiente != null){
            referencia = cabecera.Siguiente;
            valor = referencia.Dato;
        }
        return valor;
    }

    //Apuntador
    public void Apuntador(){
        referencia = cabecera;
        while(referencia.Siguiente != null){
            referencia = referencia.Siguiente;
            int dato = referencia.Dato;

            Console.WriteLine("[{0}]", dato);
        }
    }
}
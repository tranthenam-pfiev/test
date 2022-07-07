class shape {
    public string name {get;set;}
    public float area();
}

class square : shape
{
    private float edge {get;set;}

    public float area()
    {
        return this.edge*4;
    }
}
class rectangle : shape
{
    private float length {get;set;}
    private float width {get;set;}

    public float area()
    {
        return this.length*this.width;
    }
}

class triangle : shape
{
    private float e1 {get;set;}
    private float e2 {get;set;}
    private float e3 {get;set;}

    public float area()
    {
        float halfC = (e1 + e2 + e3)/2;
        if(e1+e2>e3 && e2+e3>e1 && e1+e3>e2){
            return sqrt(halfC*(halfC-e1)*(halfC-e2)*(halfC-e3));
        }
        else return 0;
    }
}
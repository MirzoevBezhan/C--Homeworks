class Gauge
{
    public int Value { get; set; } 
    public Gauge(){
      this.Value=0;
    }
     public void Enhance(){
        this.Value+=1;
     if (this.Value>5)
     {
        this.Value=5;
     }
     }
     public void Decrease(){
        this.Value-=1;
        if (this.Value<0)
        {
            this.Value=0;
        }
     }
    public bool Full(){
        if (this.Value==5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
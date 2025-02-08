class Counter
{
   public int Value;

   public Counter(){
    this.Value=0;
   }
   public Counter(int startValue){
    this.Value=startValue;
   }
   public void Increase(){
    this.Value+=1;
   }
   public void Increase(int IncreaseBy){
    if (IncreaseBy>0){
    this.Value+=IncreaseBy;
    }
   }
   public void Decrease(){
    if (this.Value<0)
    {
        this.Value=0;
    }
    this.Value-=1;
   }
   public void Decrease(int DecreaseBy){
    this.Value-=DecreaseBy;
    if (this.Value<0)
    {
        this.Value=0;
    }
   }
   public void Show(){
    System.Console.WriteLine("Value: " + this.Value);
   }

}
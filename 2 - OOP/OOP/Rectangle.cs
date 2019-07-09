class Rectangle
{
     public Rectangle()
    {
       
    }
    public Rectangle(int _width, int  _height)
    {
        this._height = _height;
        this._width = _width;
    }
    private int _width ;
    //public int _height{get; set;}
       public int _height{
           get{
               
               return _height;
           } 
           set{
               if(value>0)
               _height=value;
           }

           }
        public int Area{
            get{
               return _height * _width;
            }
        }

    public int getWidth(){
   return _width;
    }
    public void setWidth(int x){
        if(x>0){
            _width= x;
        }
    }



//Distructor




}
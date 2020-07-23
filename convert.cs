bool[] sensores = new bool[8];

while(true){
    for(int i = 0; i < 5; i++){
        sensores[i] = !bc.returnColor(i).Equals("BRANCO");
    }

    int x = 4;
    int error = 0;
    foreach(bool u in sensores){
        error += (int)Math.Pow(2, x) * Convert.ToInt32(u);
        x--;
    }
    error-=4;
    bc.printLCD(1, error.ToString());
    bc.printLCD(2, bc.returnColor(1).Equals("BRANCO").ToString());
}
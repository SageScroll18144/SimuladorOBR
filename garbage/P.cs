bool[] sensores = new bool[8];
int[] errors = {1, 3, 2, 6, 4, 12, 8, 24, 16};

int kp = 100;
int velocity = 50;

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
    bc.printLCD(1, error.ToString()); 
    if(error != 0){
        for (int i = 0; i < 9; i++){
            if(error == errors[i]){
                error = i;
                break;
            }
        }
        error-=4;
    }
    bc.printLCD(2, error.ToString());
    bc.printLCD(3, bc.returnColor(1).Equals("BRANCO").ToString());

    bc.onTF(velocity - (kp *error), velocity + (kp *error));          
    
}
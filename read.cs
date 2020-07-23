Func<string, bool> isWhite = x =>  x.Equals("BRANCO");

bool[] sensores = new bool[8];

while(true){
    for(int i = 0; i < 5; i++){
        sensores[i] = isWhite(bc.returnColor(i+1));
    }    
    bc.printLCD(1,  isWhite("PRETO").ToString());
}
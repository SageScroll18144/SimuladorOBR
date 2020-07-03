Func<string, bool> isWhite = x =>  x.Equals("BRANCO");

while(1){
    bc.printLCD(1,  isWhite("BRANCO").ToString());

}

Func<string, bool> isWhite = x =>  x.Equals("BRANCO");

while(true){
    bc.printLCD(1,  isWhite("BRANCO").ToString());

}

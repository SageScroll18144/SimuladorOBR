int kp = 20;

int velocity = 50;
//TESTE
while(true){
    if(bc.returnColor(4).Equals("PRETO")){
        bc.onTF(100, 100);
        bc.wait(850);
        bc.onTFRot(90,-90);
        bc.onTF(-100, -100);
        bc.wait(325);
        
    }else if(bc.returnColor(0).Equals("PRETO")){
        bc.onTF(100, 100);
        bc.wait(850);
        bc.onTFRot(90,90);
        bc.onTF(-100, -100);
        bc.wait(325);
        
    }//VERDE
    else if((bc.returnColor(1).Equals("VERDE")||bc.returnColor(0).Equals("VERDE"))&&bc.returnColor(3).Equals("BRANCO")){
        bc.onTF(100, 100);
        bc.wait(850);
        if((bc.returnColor(1).Equals("PRETO")||bc.returnColor(0).Equals("PRETO")||bc.returnColor(2).Equals("PRETO")||bc.returnColor(3).Equals("PRETO")||bc.returnColor(4).Equals("PRETO"))){
            while(!bc.returnColor(4).Equals("PRETO")){
                bc.onTF(-100, 100);
            }     
        }
        while(!bc.returnColor(2).Equals("PRETO")){
            bc.onTF(-100, 100);
        }
        bc.onTF(-100, -100);
        bc.wait(200);
    }else if(bc.returnColor(1).Equals("BRANCO")&&(bc.returnColor(3).Equals("VERDE")||bc.returnColor(4).Equals("VERDE"))){
        bc.onTF(100, 100);
        bc.wait(850);
        if((bc.returnColor(3).Equals("PRETO")||bc.returnColor(4).Equals("PRETO")||bc.returnColor(2).Equals("PRETO")||bc.returnColor(1).Equals("PRETO")||bc.returnColor(0).Equals("PRETO"))){
            while(!bc.returnColor(0).Equals("PRETO")){
                bc.onTF(100, -100);
            }       
        }
        while(!bc.returnColor(2).Equals("PRETO")){
            bc.onTF(100, -100);
        }
        bc.onTF(-100, -100);
        bc.wait(200);
    }else if(bc.returnColor(1).Equals("VERDE")&&bc.returnColor(3).Equals("VERDE")){
        bc.onTFRot(90,180);
    }else{
        double error = - bc.lightness((int)1) + bc.lightness((int)3);
    
        double PID = kp * error;    
        bc.printLCD(1, ((int)PID).ToString());
   
        int A = velocity - (int)PID;    
        int B = velocity + (int)PID;

        bc.onTF(A, B);
    }
}
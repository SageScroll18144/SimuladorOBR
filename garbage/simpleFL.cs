/*
* W-Educ
* http://weduc.natalnet.br
* (C) Copyright 2014-2020
* */

int forIteratorLevelN = 0;        
int[] forIteratorLevel;
forIteratorLevel = new int[10];

while (1 == 1) {
    bc.printLCD(1, bc.returnColor((int)(2-1), 0.55f));
    bc.printLCD(2, bc.returnColor((int)(3-1), 0.55f));
    bc.printLCD(3, bc.returnColor((int)(4-1), 0.55f));
    if (bc.returnColor((int)(2-1), 0.55f) ==  "PRETO"  && bc.returnColor((int)(4-1), 0.55f) ==  "BRANCO" ) {
        bc.onTF((-60), 60);
        bc.wait(500);

    }

    if (bc.returnColor((int)(4-1), 0.55f) ==  "PRETO"  && bc.returnColor((int)(2-1), 0.55f) ==  "BRANCO" ) {
        bc.onTF(60, (-60));
        bc.wait(500);

    }

    if (bc.returnColor((int)(4-1), 0.55f) ==  "BRANCO"  && bc.returnColor((int)(2-1), 0.55f) ==  "BRANCO" ) {
        bc.onTF(50, 50);

    }
}
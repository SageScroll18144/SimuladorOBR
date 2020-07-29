#include <stdio.h>
#include <math.h>

int main(){

    int n = 4;

    int b, c;
    b = n << 1;
    c = n >> 1;

    printf("%f %d", log2(n/n), c);

    return 0;
}
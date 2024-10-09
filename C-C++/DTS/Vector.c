#include<stdio.h>
#include<stdlib.h>
int main(){
    int a[2] = {2,3};
    int* b = (int*)malloc(2*sizeof(int));

    //a=b;
    for (int i = 0; i < 2; i++) {
        b[i] = a[i];
    }
    a[0] = 100;
    for (int i = 0; i <2; i++){
        printf("%d", b[i]);
    }
    printf("\n");
    free(b);
    return 0;
    
}
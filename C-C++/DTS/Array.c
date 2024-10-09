#include<stdio.h>
//static array<list good
int main(){
    int a[2] ={10, 20};

     for(int i = 0; i<(sizeof(a)/sizeof(a[0]));i++){
         printf("%d",a[i]);
     }
    // for(int i= 0; i<2; i++){
    //     printf("\n");
    // }return 0;
    
}
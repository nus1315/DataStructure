#include<iostream>//C++
using namespace std;

int main(){
    int a[2] = {10, 20};

    for(int i = 0; i < (sizeof(a) / sizeof(a[0])); i++){
        cout << a[i] << " ";  
    }
    cout << endl;
}

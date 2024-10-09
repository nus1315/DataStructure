#include<iostream>
#include<set>

using namespace std;

int main(){
    set<int> s = {4,3,7,2,2,1,1,1,1,1,1};

    cout << "Size = " << s.size() << endl;

    s.insert(10);
    s.insert(5);
    s.erase(10);

    cout << "num : " ;
    for (auto it = s.begin();it != s.end();it++)
    cout << *it <<"";
}
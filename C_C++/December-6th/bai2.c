#include<stdio.h>
#include<stdlib.h>
 
struct LinkedList {
    int data;
    struct LinkedList *next;
    struct LinkedList *prev;
};
 
typedef struct LinkedList *node; 
 
node CreateNode(int value) {
    node temp;
    temp = (node)malloc(sizeof(struct LinkedList));
    temp->data = value;
    temp->prev = NULL;
    temp->next = NULL;
    return temp;
}
 
node AddTail(node head, node tail, int value) {
    node temp = CreateNode(value);
    if(head == NULL) {
        head = temp;
        tail = temp;
        return;
    }
    tail->next = temp;
    temp->prev = tail;
    tail = temp;
    return head;
}

node AddHead(node head, node tail, int value){
    node temp = CreateNode(value); 
    if(head == NULL){
        head = temp; 
        tail = temp;
        return head;
    }else{
        head->prev = temp;
        temp->next = head;
        tail = head;
        head = temp; 
    }
    return head;
}

 node AddAt(node head, node tail, int value, int position){
    if(position == 0 || head == NULL){
        head = AddHead(head, tail, value);
    }else{
        int k = 1;
        node p = head;
        while(p != NULL && k != position){
            p = p->next;
            ++k;
        }
 
        if(k != position){
            head = AddTail(head, tail, value);
        }else{
            node temp = CreateNode(value);
            temp->next = p->next;
            p->next = temp;
            temp->prev = p;
            p->next->prev = temp;
        }
    }
    return head;
}

node DelHead(node head, node tail){
    if(head == NULL){
        printf("\nCha co gi de xoa het!");
    }else{
        head = head->next;
        head->prev = NULL;
    }
    return head;
}

node DelTail(node head, node tail){
    if (head == NULL || head->next == NULL){
         return DelHead(head, tail);
    }
    tail = tail->prev;
    tail->next = NULL;
    return head;
}

int Length(node head, node tail){
    int length = 0;
    for(node p = head; p != tail->next; p = p->next){
        ++length;
    }
    return length;
}

node DelAt(node head, node tail, int position){
    if(position == 0 || head == NULL || head->next == NULL){
        head = DelHead(head, tail); 
    }
    else if (position == Length(head) - 1){
        head = DelTail(head, tail);
    }
    else{
        int k = 1;
        node p = head;
        while(p->next->next != NULL && k != position){
            p = p->next;
            ++k;
        }
 
        if(k != position){
            head = DelTail(head, tail);
        }else{
            p->next = p->next->next;
            p->next->prev = p;
        }
    }
    return head;
}

int Search(node head, node tail, int value){
    int position = 0;
    for(node p = head; p != tail->next; p = p->next){
        if(p->data == value){
            return position;
        }
        ++position;
    }
    return -1;
}

node DelByVal(node head, node tail, int value){
    int position = Search(head, tail, value);
    while(position != -1){
        head = DelAt(head, tail, position);
        position = Search(head, tail, value);
    }
    return head;
}

void Output(node head, node tail) {
    printf("\nXuat danh sach the chieu xuoi: \n");
    for(node p = head; p != NULL; p = p->next){
        printf("%5d ", p->data);
    }
    printf("\n");
}
 
void ReverseOutput(node head, node tail) {
    printf("\nXuat danh sach the chieu nguoc: \n");
    for(node p = tail; p != NULL; p = p->prev){
        printf("%5d ", p->data);
    }
    printf("\n");
}

node Input(){
    head = NULL;
    tail = NULL;
    int n, value;
    do{
        printf("\nNhap so luong phan tu n = ");
        scanf("%d", &n);
    }while(n <= 0);
 
    for(int i = 0; i < n; ++i){
        printf("\nNhap gia tri can them: ");
        scanf("%d", &value);
        head = AddTail(head, value);
    }
    return head;
}
 
int main() {
    printf("\nTao 1 danh sach lien ket: "); 
    node tail = NULL;
    node head = Input();
    Output(head, tail);
    ReverseOutput();
}
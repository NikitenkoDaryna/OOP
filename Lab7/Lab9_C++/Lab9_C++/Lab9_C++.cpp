// Lab9_C++.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
class Node {
public:
    double data;
    Node* next;
    Node* prev;
};
/* Given a reference (pointer to pointer) to the head of a list
and an double, inserts a new node on the front of the list. */
void push(Node** head_ref, double new_data) {

    Node* new_node = new Node();
    new_node->data = new_data;
    /* Make next of new node as head and previous*/
    new_node->next = (*head_ref);
    new_node->prev = NULL;
    /* change prev of head node to new node*/
    if ((*head_ref) != NULL)
        (*head_ref)->prev = new_node;
    (*head_ref) = new_node;
}
void append(Node** head_ref, int new_data)
{
    /* 1. allocate node */
    Node* new_node = new Node();

    Node* last = *head_ref; 

    /* 2. put in the data */
    new_node->data = new_data;

    /* 3. This new node is going to be the last node, so
        make next of it as NULL*/
    new_node->next = NULL;

    /* 4. If the Linked List is empty, then make the new
        node as head */
    if (*head_ref == NULL)
    {
        new_node->prev = NULL;
        *head_ref = new_node;
        return;
    }

    /* 5. Else traverse till the last node */
    while (last->next != NULL)
        last = last->next;

    /* 6. Change the next of last node */
    last->next = new_node;

    /* 7. Make last node as previous of new node */
    new_node->prev = last;
    return;
}
int findSize(Node*node) {
    int res = 0;
    while (node!=NULL) {
        res++;
        node = node->next;
    }
    return res;
}
double calcAverage(Node*node) {
    double av = 0;
   int size = findSize(node);
    while (node!=NULL) {
        av += node->data;
        node = node->next;
    }
    av = av / size;
    return av;
}
void deleteNode(class Node** head_ref,Node* del) {
    if (*head_ref == NULL || del == NULL)
        return;

    // If the node to be deleted is head node 
    if (*head_ref == del)
        *head_ref = del->next;

    // Change next only if node to be 
    // deleted is not the last node 
    if (del->next != NULL)
        del->next->prev = del->prev;

    // Change prev only if node to be 
    // deleted is not the first node 
    if (del->prev != NULL)
        del->prev->next = del->next;

    // Finally, free the memory 
    // occupied by del 
    free(del);

    return;
}

double findMax(Node** head_ref) {
    class Node* max, * temp;
    temp = max = *head_ref;
    while (temp!=NULL) {
        if (temp->data > max->data)
            max = temp;
        temp = temp->next;
    }
    return max->data;
}
void deleteElBeforeMax(Node** head_ref) {
    double max = findMax(head_ref);
    Node* ptr = *head_ref;
    Node* next;
    while (ptr!=NULL) {
        next = ptr->next;
        if (ptr->data != max)
            deleteNode(head_ref, ptr);
        else break;
        ptr = next;

    }
}

int calcElements(Node* node,double av) {
    int count = 0;
    
    while (node!=NULL) {
        if (node->data < av)
            count++;
        node = node->next;
    }
    return count;
}

void printList(Node* node)
{
    Node* last = new Node();
    cout << "\nTraversal in forward direction \n";
    while (node != NULL)
    {
        cout << " " << node->data << " ";
        last = node;
        node = node->next;
    }

    /*cout << "\nTraversal in reverse direction \n";
    while (last != NULL)
    {
        cout << " " << last->data << " ";
        last = last->prev;
    }*/
}




int main()
{
    Node* head = NULL;
    append(&head, 6); 
    append(&head,8);
    append(&head,12);
    append(&head,15);
    //add first element
    push(&head,17);
    printList(head);
    cout << endl;
    double av = calcAverage(head);
    cout <<"Average:"<< av<<endl;
    cout << calcElements(head,av)<<endl;
   // cout << findMax(&head);
    deleteElBeforeMax(&head);
    printList(head);
}

#ifndef LIST_H
#define LIST_H

typedef struct Node {
    int data;
    struct Node* next;
} Node;

Node* create_list();
void add_front(Node** head, int data);
void add_end(Node** head, int data);
void add_after(Node* head, int target, int data);
void add_before(Node** head, int target, int data);
void delete_front(Node** head);
void delete_end(Node** head);
void delete_node(Node** head, int target);
Node* search(Node* head, int target);
void print_list(Node* head);
void free_list(Node* head);

#endif

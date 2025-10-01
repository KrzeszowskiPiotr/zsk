#include <stdio.h>
#include <stdlib.h>
#include "list.h"

Node* create_list() {
    return NULL;
}

void add_front(Node** head, int data) {
    Node* new_node = malloc(sizeof(Node));
    new_node->data = data;
    new_node->next = *head;
    *head = new_node;
}

void add_end(Node** head, int data) {
    Node* new_node = malloc(sizeof(Node));
    new_node->data = data;
    new_node->next = NULL;
    if (*head == NULL) {
        *head = new_node;
        return;
    }
    Node* temp = *head;
    while (temp->next)
        temp = temp->next;
    temp->next = new_node;
}

void add_after(Node* head, int target, int data) {
    Node* temp = head;
    while (temp && temp->data != target)
        temp = temp->next;
    if (temp) {
        Node* new_node = malloc(sizeof(Node));
        new_node->data = data;
        new_node->next = temp->next;
        temp->next = new_node;
    }
}

void add_before(Node** head, int target, int data) {
    if (*head == NULL) return;
    if ((*head)->data == target) {
        add_front(head, data);
        return;
    }
    Node* prev = NULL;
    Node* curr = *head;
    while (curr && curr->data != target) {
        prev = curr;
        curr = curr->next;
    }
    if (curr) {
        Node* new_node = malloc(sizeof(Node));
        new_node->data = data;
        new_node->next = curr;
        prev->next = new_node;
    }
}

void delete_front(Node** head) {
    if (*head == NULL) return;
    Node* temp = *head;
    *head = (*head)->next;
    free(temp);
}

void delete_end(Node** head) {
    if (*head == NULL) return;
    if ((*head)->next == NULL) {
        free(*head);
        *head = NULL;
        return;
    }
    Node* prev = NULL;
    Node* curr = *head;
    while (curr->next) {
        prev = curr;
        curr = curr->next;
    }
    prev->next = NULL;
    free(curr);
}

void delete_node(Node** head, int target) {
    if (*head == NULL) return;
    if ((*head)->data == target) {
        delete_front(head);
        return;
    }
    Node* prev = NULL;
    Node* curr = *head;
    while (curr && curr->data != target) {
        prev = curr;
        curr = curr->next;
    }
    if (curr) {
        prev->next = curr->next;
        free(curr);
    }
}

Node* search(Node* head, int target) {
    while (head) {
        if (head->data == target)
            return head;
        head = head->next;
    }
    return NULL;
}

void print_list(Node* head) {
    while (head) {
        printf("%d -> ", head->data);
        head = head->next;
    }
    printf("NULL\n");
}

void free_list(Node* head) {
    while (head) {
        Node* temp = head;
        head = head->next;
        free(temp);
    }
}

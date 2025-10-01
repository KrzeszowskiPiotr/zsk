#include <stdio.h>
#include "list.h"
#include "stack.h"
#include "queue.h"

int main() {
    printf("=== Lista jednokierunkowa ===\n");
    Node* list = create_list();
    add_end(&list, 10);
    add_front(&list, 5);
    add_end(&list, 15);
    add_after(list, 10, 12);
    add_before(&list, 15, 13);
    print_list(list);

    delete_node(&list, 12);
    delete_front(&list);
    delete_end(&list);
    print_list(list);

    Node* found;

// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var selectedItemId = null;

function showItemDetails(itemId) {
	// Set the selected item ID
	selectedItemId = itemId;

	// Show the item details modal
	$("#itemDetailsModal").modal("show");
}

function showEditItemModal(itemId) {
	// Set the selected item ID
	selectedItemId = itemId;

	// Show the edit item modal
	$("#editItemModal").modal("show");
}

function showDeleteItemModal(itemId) {
	// Set the selected item ID
	selectedItemId = itemId;

	// Show the delete item modal
	$("#deleteItemModal").modal("show");
}

function closeModal(modalId) {
	// Close the specified modal
	$(modalId).modal("hide");
}

function updateItem() {
	// Perform the necessary actions to update the item
	// You can use the selectedItemId variable to identify the item to be updated

	// Close the edit item modal
	closeModal("#editItemModal");
}

function deleteItem() {
	// Perform the necessary actions to delete the item
	// You can use the selectedItemId variable to identify the item to be deleted

	// Close the delete item modal
	closeModal("#deleteItemModal");
}

function submitAddItemForm() {
	const titleInput = document.getElementById("addTitle");
	const descriptionInput = document.getElementById("addDescription");

	const title = titleInput.value;
	const description = descriptionInput.value;

	// Perform any necessary data validation

	const newItem = {
		title: title,
		description: description,
	};

	// Send the data to the API endpoint using Fetch API or any other method
	fetch("/api/items", {
		method: "POST",
		headers: {
			"Content-Type": "application/json",
		},
		body: JSON.stringify(newItem),
	})
		.then((response) => response.json())
		.then((data) => {
			// Handle the API response
			console.log(data);
			// Optionally, you can refresh the item list or update it with the new item
		})
		.catch((error) => {
			// Handle any errors
			console.error(error);
		});

	// Reset the form inputs
	titleInput.value = "";
	descriptionInput.value = "";

	// Close the modal
	$("#addItemModal").modal("hide");
}

$(() => {
    console.log("Eu DeveloperList");

    $("#btnEdit").on("click", () => {
        console.log("Edit");

        //$.ajax({
        //    url: "/Developer/Add",
        //    type: "GET",
        //    data: {},
        //    success: (data) => {

        //    },
        //    error: (error) => {

        //    },
        //    complete: () => {

        //    }
        //});

    });

    $("#btnRemove").on("click", () => {
        console.log("Remove");

        $.ajax({
            url: "/Developer/Delete",
            type: "DELETE",
            data: { id: 1 },
            success: (data) => {

            },
            error: (error) => {

            },
            complete: () => {

            }
        });
    });
})
document.addEventListener("DOMContentLoaded", () => {
    const onlyNumberInputs = document.querySelectorAll(".only-numbers");

    onlyNumberInputs.forEach(input => {
        input.addEventListener("input", () => {
            input.value = input.value.replace(/\D/g, "");
        });
    });
});
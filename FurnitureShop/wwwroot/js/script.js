function generateContent() {
    var selectIndex = document.getElementById("category").options.selectedIndex;
    var selectValue = document.getElementById("category").options[selectIndex].value;
    var selectTypes = document.getElementById("type");

    selectTypes.innerHTML = "";
    var arrCategory;
    var arrTypesId;

    if (selectValue == "1") {
        arrCategory = ["Диваны", "Кресла", "Письменные столы", "Стулья", "Книжные шкафы", "Журнальные столики"];
        arrTypesId = [1, 2, 3, 4, 5, 6];
    }
    else if (selectValue == "2") {
        arrCategory = ["Кровати", "Прикроватные тумбы", "Комоды", "Шкафы", "Туалетные столики"];
        arrTypesId = [7, 8, 9, 10, 11];
    }
    else if (selectValue == "3") {
        arrCategory = ["Лампы", "Раковины", "Зеркала", "Шкафы для ванной"];
        arrTypesId = [12, 13, 14, 15];
    }
    else if (selectValue == "4") {
        arrCategory = ["Столы", "Стулья", "Кухонные гарнитуры", "Раковины"];
        arrTypesId = [16, 17, 18, 19];
    }
    else if (selectValue == "5") {
        arrCategory = ["Кровати", "Письменные столы", "Комоды", "Шкафы"];
        arrTypesId = [20, 21, 22, 23];

    }
    else if (selectValue == "6") {
        arrCategory = ["Компьютерные столы", "Компьютерные кресла", "Ламы", "Стеллажи"];
        arrTypesId = [24, 25, 26, 27];
    }
    else if (selectValue == "7") {
        arrCategory = ["Зеркала", "Напольные вешалки", "Полки для обуви", "Шкафы"];
        arrTypesId = [28, 29, 30, 31];
    }


    var j = 0;

    for (var i = 0; i < arrCategory.length; i++) {
        var option = document.createElement('option');
        option.text = arrCategory[i];

        while (j < arrTypesId.length) {
            option.value = arrTypesId[j];
            j++;
            break;
        }
       
        selectTypes.appendChild(option);
    }
}

//function getImage(files) {
//    var file = files[0];

//    var reader = new FileReader();
//    reader.readAsArrayBuffer(file);

//    var result = reader.result;
//    console.log(result);

//    var bytesImage = document.getElementsByName('bytesImage');
//    bytesImage.textContent = result;
//}



function getTypes() {
    var types = document.getElementsByName("check");
    var listId = document.getElementsByName("id");
    var selectedTypes = document.getElementById("selectedTypes");

    for (var i = 0; i < types.length; i++) {
        var id = document.getElementById(listId[i].value);
        if (types[i].checked && id == null) {
            var input = document.createElement('input');
            input.type = "text";
            input.name = "checks";
            input.id = listId[i].value;
            input.hidden = true;
            input.value = listId[i].value;
            input.innerText = listId[i].value;

            selectedTypes.appendChild(input);

        }
    }
}
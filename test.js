// 1 ----
function Employee(firstname, lastaname, salary) {
    this.FirstName=firstname;
    this.LastName=lastaname;
    this.Salary=salary;
}


Employee.prototype.IncreaseSalary = function() {
    this.FirstName = this.FirstName + 1000;
}

Employee.prototype.ShowDetails = function() {
    console.log("Firstname: " + this.FirstName + " - LastName: " + this.LastName + " - Salary: " + this.Salary);
}

// 2 ----
function MultiplyBy(x) {
    return function(y) {
        return function(z) {
            return x * y * z;
        };
    };
}

// 3 ----
function Longest_Country_Name(arr) {
    for(var i = 1; i < arr.length; i++) {
        var longest = arr[0];
        if (arr[i].length > longest.length) {
            longest = arr[i];
        }
    }
    return longest;
}


// 4 ----
function removecolor()
{
    var itemSelected = document.getElementById("colorSelect");
    itemSelected.remove(x.selectedIndex);
}


// 5 ----
function insert_Row()
{
    var newRow = document.getElementById('sampleTable').insertRow(0);
    var newCell1 = x.insertCell(0);
    var newCell2 = x.insertCell(1);
    newCell1.innerHTML = "New Cell1";
    newCell2.innerHTML = "New Cell2";
}
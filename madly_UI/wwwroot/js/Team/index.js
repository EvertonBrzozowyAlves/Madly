const userFactory = {
    _id: undefined,
    _name: undefined,
    _phone: undefined,
    _registerDate: undefined,
    _email: undefined,
    _password: undefined,
    
    fillAttributes(users){
        
        if(users === undefined) return

        let usersList = [];
        debugger;
        users.forEach(user => {
            this._id = user.Id, 
            this._name = user.Name,
            this._phone = user.Phone,
            this._email = user.Email, 
            this._registerDate = user.registerDate

            usersList.push(user);
        });

        return usersList;
    },

    getAll() {
        debugger;
        let users = ajaxGET('/Users/All');
        users = this.fillAttributes(users);

    },

    getById(id) {
        debugger;
        let user = ajaxGET('/User/GetById', id);
        user = this.fillAttributes(user);
        return this;
    },

    createDataTable(users){
        $('#usersDataTable').DataTable( {
            data: users,
            columns: [
                { title: "Id", "visible": false },
                { title: "Nome" },
                { title: "Email" },
                { title: "Telefone" },
                { title: "Data de Cadastro" },
                { title: "Marcações" }
            ],
            paging: false
        } );
    },

};

$(document).ready(function () {
    debugger;
    let users = userFactory.getAll();
    userFactory.createDataTable(users);



});

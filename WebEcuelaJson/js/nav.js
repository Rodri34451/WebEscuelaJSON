const $$Nav=function(){

    this.init = () => {
        $ds.nav("body");
        $dn.makeButton("Inicio", $ds.home);
        //$dn.makeDropDown("Carrera",["abm carrera", "Buscar Carrera"],[$f.addCarrera, $f.findCarrera]);
        $dn.makeDropDown("Funciones",["abm usuario","Buscar Usuario"],[$f.addUser,$f.findUser]);
        $dn.makeButtonLogin("Ingresar");
    }

}

const $nav=new $$Nav
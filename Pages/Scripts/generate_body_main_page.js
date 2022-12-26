
function getCategorias() {

    let url = new URL(window.location.href);

    let string_categorias = url.searchParams.get("categorias");

    let result = string_categorias.split(";");

    result[result.length] = "random";

    return result;
}

function valid_categoria(nome_identificador) {

    switch (nome_identificador) {

        case "casa_e_decoracao": return true;
        case "animais": return true;
        case "mercearia_e_produtos_frescos": return true;
        case "cultura": return true;
        case "veiculos": return true;
        case "escritorio": return true;
        case "bricolagem": return true;
        case "animais_de_estimacao": return true;
        case "brinquedos": return true;
        case "gaming": return true;
        case "lazer": return true;
        case "saude": return true;
        case "beleza": return true;
        case "eletrodomesticos": return true;
        case "imagem": return true;
        case "som": return true;
        case "smartphones_e_acessorios": return true;
        case "informatica": return true;
        case "desporto": return true;
        case "moda": return true;
        case "random": return true;

        default: return false;
    }
}

function nome_identificador_to_nome_completo(nome_identificador) {

    switch (nome_identificador) {

        case "casa_e_decoracao": return "CASA E DECORAÇÃO";
        case "animais": return "ANIMAIS";
        case "mercearia_e_produtos_frescos": return "MERCEARIA E PRODUTOS FRESCOS";
        case "cultura": return "CULTURA";
        case "veiculos": return "VEÍCULOS";
        case "escritorio": return "ESCRITÓRIO";
        case "bricolagem": return "BRICOLAGEM";
        case "animais_de_estimacao": return "ANIMAIS DE ESTIMAÇÃO";
        case "brinquedos": return "BRINQUEDOS";
        case "gaming": return "GAMING";
        case "lazer": return "LAZER";
        case "saude": return "SAÚDE";
        case "beleza": return "BELEZA";
        case "eletrodomesticos": return "ELETRODOMÉSTICOS";
        case "imagem": return "IMAGEM";
        case "som": return "SOM";
        case "smartphones_e_acessorios": return "SMARTPHONES E ACESSÓRIOS";
        case "informatica": return "INFORMÁTICA";
        case "desporto": return "DESPORTO";
        case "moda": return "MODA";
        case "random": return "";

        default: return null;
    }
}

function nome_identificador_to_img_url(nome_identificador) {
    
    switch (nome_identificador) {

        case "casa_e_decoracao": return "Images/categoria_" + nome_identificador + ".png";
        case "animais": return "Images/categoria_" + nome_identificador + ".png";
        case "mercearia_e_produtos_frescos": return "Images/categoria_" + nome_identificador + ".png";
        case "cultura": return "Images/categoria_" + nome_identificador + ".png";
        case "veiculos": return "Images/categoria_" + nome_identificador + ".png";
        case "escritorio": return "Images/categoria_" + nome_identificador + ".png";
        case "bricolagem": return "Images/categoria_" + nome_identificador + ".png";
        case "animais_de_estimacao": return "Images/categoria_" + nome_identificador + ".png";
        case "brinquedos": return "Images/categoria_" + nome_identificador + ".png";
        case "gaming": return "Images/categoria_" + nome_identificador + ".png";
        case "lazer": return "Images/categoria_" + nome_identificador + ".png";
        case "saude": return "Images/categoria_" + nome_identificador + ".png";
        case "beleza": return "Images/categoria_" + nome_identificador + ".png";
        case "eletrodomesticos": return "Images/categoria_" + nome_identificador + ".png";
        case "imagem": return "Images/categoria_" + nome_identificador + ".png";
        case "som": return "Images/categoria_" + nome_identificador + ".png";
        case "smartphones_e_acessorios": return "Images/categoria_" + nome_identificador + ".png";
        case "informatica": return "Images/categoria_" + nome_identificador + ".png";
        case "desporto": return "Images/categoria_" + nome_identificador + ".png";
        case "moda": return "Images/categoria_" + nome_identificador + ".png";
        case "random": return "Images/categoria_" + nome_identificador + ".png";

        default: return null;
    }
}

function html_code_to_one_button(nome_identificador) {

    let code = '<div class="container_categoria"><img src="';

    code += nome_identificador_to_img_url(nome_identificador);

    code += '" alt=""><p>';

    code += nome_identificador_to_nome_completo(nome_identificador);

    code += '</p></div>';

    return code;
}

function html_code_to_all_buttons() {

    let categorias = getCategorias();

    let code = "";

    for (let i = 0; i < categorias.length; i++) {

        if (valid_categoria(categorias[i])) {

            code += html_code_to_one_button(categorias[i]);
        }
    }

    return code;
}

function display_main_page_body() {

    let main_page_elem = document.getElementById("main_page");

    main_page_elem.innerHTML = html_code_to_all_buttons();
}

display_main_page_body();
<h1 align=center>
<img src="https://raw.githubusercontent.com/jgsneves/eCommerceCsharp/master/Capturar.PNG" />
</h1>

<h3 align="center">

Projeto desenvolvido com a intenção de estudar a arquitetura MVC ser aplicada em uma aplicação toda construída em ASP Net Core (AngularJS, Bootstrap e C#)

</h3>

## **:memo:  __O QUE É ESTE PROJETO?**

O projeto visa criar uma loja virtual (e-commerce) onde seja exibida uma lista de produtos a venda, com implementação de autorizações e controle de acesso de usuários, havendo usuários comuns e também outros com poder de Admin, que poderiam adicionar ou remover itens disponíveis a venda, podendo também editar preços, imagens e descrição destes produtos. Os usuários comuns apenas podem ver os produtos e comprá-los.

## **:computer:  __TECNOLOGIAS**


#### **Front-end do site:** [React][react] utilizando a tipagem do [TypeScript][typescript]

  - **[React Icons][react_icons]**
  - **[React Router Dom][react_router_dom]**
  - **[Axios][axios]**
  - **[React Leaflet][react_leaflet]**
  - **[React Dropzone][react_dropzone]**


===================

#### **Back-end:** Servidor em [NodeJS][node] utilizando a tipagem do [TypeScript][typescript]

  - **[Express][express]**
  - **[CORS][cors]**
  - **[KnexJS][knex]**
  - **[SQLite][sqlite3]**
  - **[Multer][multer]**
  - **[Celebrate][celebrate]**
  - **[Joi][joi]**

===================

#### **Mobile:** [React Native][react_native] utilizando a tipagem do [TypeScript][typescript]

  - **[Expo][expo]**
  - **[Expo Google Fonts][expo_google_fonts]**
  - **[React Navigation][react_navigation]**
  - **[React Native Maps][react_native_maps]**
  - **[Expo Constants][expo_constants]**
  - **[React Native SVG][react_native_svg]**
  - **[Axios][axios]**
  - **[Expo Location][expo_location]**
  - **[Expo Mail Composer][expo_mail_composer]**


## **:runner: __Instruções Para Compilar e Executar a Aplicação:**

### Configs do Servidor:

1) Instancia o NPM dentro do diretório:
```sh
	npm init -y                     # -y faz com que o node não faça perguntas de versão
```
2) Instala o ExpressJS:
```sh
	npm install express                      # o Express é responsável pelas rotas da API
```
3) Define os tipos do express:
```sh
	npm install @types/express -D            #-D cria uma dependência de desenvolvimento
```
4) Para executar o servidor, precisa instalar o TS-NODE:
```sh
	npm install ts-node -D
```
5) Instalar o typescript>
```sh
	npm install typescript -D
```
6) Criar arquivo de configuração o typescript:
```sh
	npx tsc --init
```
7) Executar o ts-node passando o servidor como argumento:
```sh
	npx ts-node src/<nome>.ts
```
8) Para criar o atralho de run, instalar o ts-node-dev:
```sh
	npm install ts-node-dev -D
```
9) Acessar o package.json e mudar o scripts:
```js
	"scripts": {
    		"<nome_do_comando_que_vc_quer>": "ts-node-dev src/<nome>.ts"
  	},
```
10) Agora você tem o atalho:
```sh
	npm run <nome_do_comando_que_vc_quer>
```
11) Pacote para lidar com upload de imagens:
```sh
	npm install multer
```
12) Para fazer validação de formulário, usar o Celebrate:
```sh
	npm install celebrate
```
13) Para ter o intellisense do Joi:
```sh
	npm install @types/hapi__joi -D
```

### Config do Banco de Dados (sqlite):

1) Instala o knex (serve para interfaciar o BD SQL em qualquer formato de IDE):
```sh
	npm install knex
```
2) Instala o SQLite3 (pode ser qualquer outro, de acordo com documentação KNEX):
```sh
	npm install sqlite3
```
3) Fazer migration usando knex:
```sh
	npx knex migrate:latest --knexfile knexfile.ts migrate:latest
```

### Config do Front-end (ReactJS):


1) Cria o React App:
```sh	
	npx create-react-app <nome> --template=typescript
```
2) instalar pacote de icones:
```sh
	npm install react-icons
```
3) Rotas no react:
```sh
	npm install react-router-dom
```
4) Pro typescript precisamos instalar a declaração de tipagem do router:
```sh
	npm install @types/react-router-dom -D
```
5) API de maps (a do google não é 100% open source):
```sh	
	https://leafletjs.com/
	https://react-leaflet.js.org/

	npm install leaflet react-leaflet
```
6) Pro typescript precisamos instalar a declaração de tipagem do leaftlet
```sh
	npm install @types/react-leaftlet -D
```
7) Biblioteca pra fazer requisições à API axios
```sh
	npm install axios               #usar um arquivo TS para fazer os services
```
8) Para utilizar a caixa de upload de imagem:
```sh
	npm install react-dropzone
```
### Configs do Mobile (React Native):

Instale o aplicativo <kbd>[Expo](https://play.google.com/store/apps/details?id=host.exp.exponent&hl=en)</kbd> no seu smartphone.

1) Instalar o expo CLI:
```sh
	npm install -g expo-cli
```
Instalar o aplicativo Expo disponível na Play Store ou Apple Store, apontar para o QR Code renderizado no console da sua IDE ou conectar via IP. Lembrar de editar o endereço de ip dentro do servidor para o ip da sua máquina. Também utilizar o Expo na mesma rede que sua máquina (wifi).

2) Instalar o expo google fonts:
```sh
	npm install expo-font @expo-google-fonts/{nome_da_fonte}
```
3) Instalar rota no app:
```sh
	npm install @react-navigation/native
```
4) Instalar pacotes gerais do react navigation:
```sh
	expo install react-native-gesture-handler react-native-reanimated react-native-screens react-native-safe-area-context @react-native-community/masked-view
```
5) Instalar o Stack Layout:
```sh
	npm install @react-navigation/stack
```
6) Instalar a extensão para permitir usar maps no React Native:
```sh
	npm install react-native-maps
```
7) Instalar o Expo Constants
```sh
	npm install expo-constants
```
8) Para ler SVG (imagens), precisamos instalar o pacote SVG:
```sh
	npm install react-native-svg
```
9) Instalar axios para requisições:
```sh
	npm install axios
```
10) Instalar o Expo Location para buscar a localização do user:
```sh
	npm install expo-location
```
11) Para utilizar uma tela de criação de email:
```sh
	npm install expo-mail-composer
```
12) Para fazer inputs com lista de seleção:
```sh
	npm install react-native-picker-select
```

## **:books: __REFERÊNCIAS**

- [React + TypeScript Cheat Sheet](https://github.com/typescript-cheatsheets/react-typescript-cheatsheet)
- [Blog Rocketseat](https://blog.rocketseat.com.br/)
- [ReactJS](https://reactjs.org/docs/getting-started.html) | [ReactJS pt-BR](https://pt-br.reactjs.org/docs/getting-started.html)
- [TypeScript](https://www.typescriptlang.org/docs/home.html)
- [React Native](https://reactnative.dev/docs/getting-started)
- [Expo](https://expo.io/learn)
- [Knex][knex]
- [Express](https://expressjs.com/pt-br/)
- [Node](https://nodejs.org/en/)
- [Celebrate](https://github.com/arb/celebrate)
- [Joi](https://hapi.dev/module/joi/)



<!-- Badges -->

[github_issues_badge]: https://img.shields.io/github/issues/x0n4d0/ecoleta?color=green

[repository_license_badge]: https://img.shields.io/github/license/x0n4d0/ecoleta

[node_version_badge]: https://img.shields.io/badge/node-12.17.0-green

[npm_version_badge]: https://img.shields.io/badge/npm-6.14.4-red

[web_react_badge]: https://img.shields.io/badge/web-react-blue

[mobile_react-native_badge]: https://img.shields.io/badge/mobile-react%20native-blueviolet

[server_nodejs_badge]: https://img.shields.io/badge/server-nodejs-important

<!-- Techs -->

[react]: https://reactjs.org/

[typescript]: https://www.typescriptlang.org/

[node]: https://nodejs.org/en/

[leaflet]: https://react-leaflet.js.org/en/

[ibge_api]: https://servicodados.ibge.gov.br/api/docs/localidades?versao=1

[ibge_api_ufs]: https://servicodados.ibge.gov.br/api/docs/localidades?versao=1#api-UFs-estadosGet

[ibge_api_municipios]: https://servicodados.ibge.gov.br/api/docs/localidades?versao=1#api-Municipios-estadosUFMunicipiosGet

[vscode]: https://code.visualstudio.com/

[react_native]: http://www.reactnative.com/

[stackedit]: https://stackedit.io

[vscode_sqlite_extension]: https://marketplace.visualstudio.com/items?itemName=alexcvzz.vscode-sqlite

[markdown_emoji]: https://gist.github.com/rxaviers/7360908

[commitlint]: https://github.com/conventional-changelog/commitlint

[express]: https://expressjs.com/

[cors]: https://expressjs.com/en/resources/middleware/cors.html

[knex]: http://knexjs.org/

[sqlite3]: https://github.com/mapbox/node-sqlite3

[tsnode]: https://github.com/TypeStrong/ts-node

[feather_icons]: https://feathericons.com/

[insomnia]: https://insomnia.rest/

[react_leaflet]: https://react-leaflet.js.org/

[react_router_dom]: https://github.com/ReactTraining/react-router/tree/master/packages/react-router-dom

[react_icons]: https://react-icons.github.io/react-icons/

[axios]: https://github.com/axios/axios

[dotenv]: https://github.com/motdotla/dotenv

[expo]: https://expo.io/

[expo_google_fonts]: https://github.com/expo/google-fonts

[react_navigation]: https://reactnavigation.org/

[react_native_maps]: https://github.com/react-native-community/react-native-maps

[expo_constants]: https://docs.expo.io/versions/latest/sdk/constants/

[react_native_svg]: https://github.com/react-native-community/react-native-svg

[expo_location]: https://docs.expo.io/versions/latest/sdk/location/

[expo_mail_composer]: https://docs.expo.io/versions/latest/sdk/mail-composer/

[font_roboto]: https://fonts.google.com/specimen/Roboto

[font_ubuntu]: https://fonts.google.com/specimen/Ubuntu

[font_awesome]: https://fontawesome.com/

[multer]: https://github.com/expressjs/multer

[celebrate]: https://github.com/arb/celebrate

[joi]: https://github.com/hapijs/joi

[react_dropzone]: https://github.com/react-dropzone/react-dropzone

[asdf]: https://github.com/asdf-vm/asdf

[yarn]: https://classic.yarnpkg.com/en/docs/install/#debian-stable

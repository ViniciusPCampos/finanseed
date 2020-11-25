FROM node:10

WORKDIR /app

COPY package.json .

RUN npm i

COPY . .

EXPOSE 3000

ENV HOST 0.0.0.0
RUN npm run build

CMD [ "npm", "start" ]
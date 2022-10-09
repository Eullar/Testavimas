import { useReducer } from "react";

import GameContext from "./game-context";

const defaultGameState = {
  players: [],
  gameStatus: true,
  map: [[], []],

  name: "",
  color: -1,
  isReady: false,
  isMyTurn: false,
};

const gameReducer = (state, action) => {
  if (action.type === "ADD_PLAYER") {
    const updatedPlayers = state.players.concat(action.item);
    return { ...state, players: updatedPlayers };
  }

  if (action.type === "REMOVE_PLAYER") {
    const updatedPlayers = state.players.filter(
      (player) => player.connectionID !== action.item.connectionID
    );
    return { ...state, players: updatedPlayers };
  }

  if (action.type === "CHANGE_COLOR") {
    const updatedColor = action.item;
    return { ...state, color: updatedColor };
  }

  if (action.type === "CHANGE_NAME") {
    const updatedName = action.item;
    return { ...state, name: updatedName };
  }

  if (action.type === "CHANGE_READY_STATUS") {
    const updatedPlayers = [...state.players];
    const index = updatedPlayers.findIndex(
      (item) => item.connectionID === action.item.connectionId
    );
    updatedPlayers[index].isReady = action.item.status;
    return { ...state, players: updatedPlayers };
  }

  if (action.type === "CHANGE_MY_READY_STATUS") {
    return { ...state, isReady: action.item };
  }

  if (action.type === "CHANGE_GAME_STATUS") {
    return { ...state, gameStatus: action.item };
  }

  if(action.type === "CHANGE_TURN_STATUS") {
    let newIsMyTurn = state.isMyTurn;
    const newPlayers = [...state.players];
    if(action.item.oldTurnId) {
      const player = newPlayers.find(p => p.id === action.item.oldTurnId);
      player.turn = false;
      if(player.name === state.name) {
        newIsMyTurn = false;
      }
    }

    const player = newPlayers.find(p => p.id === action.item.newTurnId);
    player.turn = true;
    if(player.name === state.name) {
      newIsMyTurn = true;
    }

    return { ...state, players: newPlayers, isMyTurn: newIsMyTurn };
  }

  if (action.type === "INSERT_MAP") {
    return { ...state, map: action.item };
  }

  if (action.type === "GAME_MOVE") {
    let newMap = [...state.map];
    const temp = newMap[action.item.toX][action.item.toY];
    newMap[action.item.toX][action.item.toY] = newMap[action.item.fromX][action.item.fromY];
    newMap[action.item.fromX][action.item.fromY] = temp;
    return { ...state, map: newMap };
  }

  return defaultGameState;
};

const GameProvider = (props) => {
  const [gameState, dispatchGameAction] = useReducer(
    gameReducer,
    defaultGameState
  );

  const addPlayerHandler = (item) => {
    dispatchGameAction({ type: "ADD_PLAYER", item: item });
  };

  const removePlayerHandler = (item) => {
    dispatchGameAction({ type: "REMOVE_PLAYER", item: item });
  };

  const changeColorHandler = (item) => {
    dispatchGameAction({ type: "CHANGE_COLOR", item: item });
  };

  const changeNameHandler = (item) => {
    dispatchGameAction({ type: "CHANGE_NAME", item: item });
  };

  const changeReadyStatusHandler = (connectionId, status) => {
    dispatchGameAction({
      type: "CHANGE_READY_STATUS",
      item: { connectionId, status },
    });
  };

  const changeMyReadyStatusHandler = (item) => {
    dispatchGameAction({ type: "CHANGE_MY_READY_STATUS", item: item });
  };

  const changeGameStatusHandler = (status) => {
    dispatchGameAction({ type: "CHANGE_GAME_STATUS", item: status });
  };

  const changeTurnStatusHandler = (oldTurnId, newTurnId) => {
    dispatchGameAction({ type: "CHANGE_TURN_STATUS", item: { oldTurnId, newTurnId } });
  }

  const insertMapHandler = (map) => {
    dispatchGameAction({ type: "INSERT_MAP", item: map });
  };

  const gameMoveHandler = (fromX, fromY, toX, toY) => {
    dispatchGameAction({
      type: "GAME_MOVE",
      item: { fromX: fromX, fromY: fromY, toX: toX, toY: toY },
    });
  };

  const gameContext = {
    players: gameState.players,
    gameStatus: gameState.gameStatus,
    map: gameState.map,

    name: gameState.name,
    color: gameState.color,
    isReady: gameState.isReady,
    isMyTurn: gameState.isMyTurn,

    addPlayer: addPlayerHandler,
    removePlayer: removePlayerHandler,
    changeColor: changeColorHandler,
    changeName: changeNameHandler,

    changeReadyStatus: changeReadyStatusHandler,
    changeMyReadyStatus: changeMyReadyStatusHandler,
    changeTurnStatus: changeTurnStatusHandler,

    changeGameStatus: changeGameStatusHandler,
    insertMap: insertMapHandler,
    gameMove: gameMoveHandler,
  };

  return (
    <GameContext.Provider value={gameContext}>
      {props.children}
    </GameContext.Provider>
  );
};

export default GameProvider;
